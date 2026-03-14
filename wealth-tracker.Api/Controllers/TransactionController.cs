using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wealth_tracker.Data;
using wealth_tracker.Models;
using Microsoft.AspNetCore.Authorization;

namespace wealth_tracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetAll(
            [FromQuery] string? category,
            [FromQuery] TransactionType? type,
            [FromQuery] DateTime? dateFrom,
            [FromQuery] DateTime? dateTo)
        {
            var query = _context.Transactions.AsQueryable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(t => t.Category.Contains(category));

            if (type.HasValue)
                query = query.Where(t => t.Type == type.Value);

            if (dateFrom.HasValue)
                query = query.Where(t => t.Date >= dateFrom.Value);

            if (dateTo.HasValue)
                query = query.Where(t => t.Date <= dateTo.Value);

            return await query.OrderByDescending(t => t.Date).ToListAsync();
        }

        [HttpGet("summary")]
        public async Task<ActionResult<object>> GetSummary()
        {
            var transactions = await _context.Transactions.ToListAsync();

            var totalIncome = transactions
                .Where(t => t.Type == TransactionType.Income)
                .Sum(t => t.Amount);

            var totalExpenses = transactions
                .Where(t => t.Type == TransactionType.Expense)
                .Sum(t => t.Amount);

            return Ok(new
            {
                Balance = totalIncome - totalExpenses,
                TotalIncome = totalIncome,
                TotalExpenses = totalExpenses,
                Count = transactions.Count
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Transaction>> GetById(Guid id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction is null)
                return NotFound();

            return transaction;
        }

        [HttpPost]
        public async Task<ActionResult<Transaction>> Create(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = transaction.Id }, transaction);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction is null)
                return NotFound();

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Transaction transaction)
        {
            if (id != transaction.Id)
                return BadRequest("Id в URL не співпадає з Id транзакції");

            var existing = await _context.Transactions.FindAsync(id);
            if (existing is null)
                return NotFound();

            existing.Date = transaction.Date;
            existing.Category = transaction.Category;
            existing.Amount = transaction.Amount;
            existing.Type = transaction.Type;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
