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
        private readonly ILogger<TransactionController> _logger;

        public TransactionController(AppDbContext context, ILogger<TransactionController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Transaction>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetAll(
            [FromQuery] string? category,
            [FromQuery] TransactionType? type,
            [FromQuery] DateTime? dateFrom,
            [FromQuery] DateTime? dateTo)
        {
            _logger.LogInformation("GetAll called with filters: category={Category}, type={Type}", category, type);
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
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
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
        [ProducesResponseType(typeof(Transaction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Transaction>> GetById(Guid id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction is null)
                return NotFound();

            return transaction;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Transaction), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Transaction>> Create(Transaction transaction)
        {
            _logger.LogInformation("Creating transaction: {Category} {Amount}", transaction.Category, transaction.Amount);
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = transaction.Id }, transaction);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            _logger.LogInformation("Deleting transaction: {Id}", id);
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction is null)
            {
                _logger.LogWarning("Transaction not found: {Id}", id);
                return NotFound();
            } 

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
