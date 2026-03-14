using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wealth_tracker.Data;
using wealth_tracker.Models;

namespace wealth_tracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetAll()
        {
            return await _context.Transactions.ToListAsync();
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
        public async Task<ActionResult<Transaction>> Create (Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = transaction.Id }, transaction);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (Guid id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction is null)
                return NotFound();

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
