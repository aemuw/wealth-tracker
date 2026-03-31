using Microsoft.EntityFrameworkCore;
using wealth_tracker.Data;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class SavingsGoalService
    {
        private readonly AppDbContext _context;
        private readonly List<SavingsGoal> _goals = new();

        public IReadOnlyList<SavingsGoal> AllGoals => _goals;
        
        public SavingsGoalService(AppDbContext context)
        {
            _context = context;
        }

        public async Task LoadAsync()
        {
            _goals.Clear();
            var goals = await _context.SavingsGoals.ToListAsync();
            _goals.AddRange(goals);
        }

        public async Task AddAsync(SavingsGoal goal)
        {
            if (goal == null)
                throw new ArgumentNullException(nameof(goal));
            _context.SavingsGoals.Add(goal);

            await _context.SaveChangesAsync();
            _goals.Add(goal);
        }

        public async Task DeleteAsync(Guid id)
        {
            var goal = _goals.FirstOrDefault(g => g.Id == id);
            if (goal == null)
                return;

            _context.SavingsGoals.Remove(goal);
            await _context.SaveChangesAsync();
            _goals.Remove(goal);
        }

        public async Task DepositAsync(Guid id, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сума має бути більше 0");

            var goal = _goals.FirstOrDefault(g => g.Id == id)
                ?? throw new InvalidOperationException("Ціль не знайдено");

            if (goal.IsCompleted)
                throw new InvalidOperationException("Ціль вже досягнута");
            
            goal.SavedAmount += amount;

            var dbGoal = await _context.SavingsGoals.FindAsync(id);
            if (dbGoal != null)
            {
                dbGoal.SavedAmount = goal.SavedAmount;
                await _context.SaveChangesAsync();
            }
        }
    }
}
