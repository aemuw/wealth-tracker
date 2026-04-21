using Microsoft.EntityFrameworkCore;
using wealth_tracker.Data;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class BudgetService
    {
        public Guid CurrentUserId { get; set; }
        public void SetUser(Guid userId) => CurrentUserId = userId;

        private readonly AppDbContext _context;
        private readonly List<BudgetLimit> _limits = new();  

        public IReadOnlyList<BudgetLimit> AllLimits => _limits;  

        public BudgetService(AppDbContext context)
        {
            _context = context;
        }

        public async Task LoadAsync()
        {
            _limits.Clear();
            var loaded = await _context.BudgetLimits.ToListAsync();
            _limits.AddRange(loaded);
        }

        public async Task AddOrUpdateAsync(BudgetLimit limit)
        {
            if (limit == null) 
                throw new ArgumentNullException(nameof(limit));

            var existing = _limits.FirstOrDefault(l =>
                l.Category == limit.Category &&
                l.Month == limit.Month &&
                l.Year == limit.Year);

            if (existing != null)
            {
                existing.LimitAmount = limit.LimitAmount;
                var dbLimit = await _context.BudgetLimits.FindAsync(existing.Id);
                if (dbLimit != null)
                {
                    dbLimit.LimitAmount = limit.LimitAmount;
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                _context.BudgetLimits.Add(limit);
                await _context.SaveChangesAsync();
                _limits.Add(limit);  
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var limit = _limits.FirstOrDefault(l => l.Id == id);
            if (limit == null) 
                return;

            _context.BudgetLimits.Remove(limit);
            await _context.SaveChangesAsync();
            _limits.Remove(limit);
        }

        public void RecalculateSpent(IEnumerable<Transaction> transactions)
        {
            foreach (var limit in _limits.Where(l => l.UserId == CurrentUserId))
            {
                limit.SpentAmount = transactions
                    .Where(t =>
                        t.Type == TransactionType.Expense &&
                        t.Category == limit.Category &&
                        t.Date.Month == limit.Month &&
                        t.Date.Year == limit.Year)
                    .Sum(t => t.Amount);
            }
        }

        public List<BudgetLimit> GetCurrentMonth()
        {
            return _limits
                .Where(l => l.UserId == CurrentUserId &&
                    l.Month == DateTime.Now.Month &&
                    l.Year == DateTime.Now.Year)
                .ToList();
        }
    }
}