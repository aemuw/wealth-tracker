using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wealth_tracker.Data;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class EfPersistenceService
    {
        private readonly AppDbContext _context;

        public EfPersistenceService()
        {
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
        }

        public async Task<List<Transaction>> LoadAsync()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task SaveAsync(Transaction transaction)
        {
            var existing = await _context.Transactions.FindAsync(transaction.Id);

            if (existing == null)
                _context.Transactions.Add(transaction);
            else
                _context.Entry(existing).CurrentValues.SetValues(transaction);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SaveAllAsync(IEnumerable<Transaction> transactions)
        {
            var existing = await _context.Transactions.ToListAsync();
            _context.Transactions.RemoveRange(existing);
            _context.Transactions.AddRange(transactions);
            await _context.SaveChangesAsync();
        }

        public string DbPath => "wealth_tracker.db";

    }
}
