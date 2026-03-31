using System;
using System.ComponentModel.DataAnnotations;

namespace wealth_tracker.Models
{
    public class SavingsGoal
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal TargetAmount { get; set; }

        public decimal SavedAmount { get; set; }


        [Required]
        public DateTime Deadline { get; set; } = DateTime.Now.AddMonths(6);

        public string? Note { get; set; }

        public decimal Progress => TargetAmount > 0 ? Math.Min(SavedAmount / TargetAmount * 100, 100) : 0;

        public bool IsCompleted => TargetAmount > 0 && SavedAmount >= TargetAmount;

        public decimal MonthlyRequired
        {
            get
            {
                var monthsLeft = ((Deadline.Year - DateTime.Now.Year) * 12) + Deadline.Month - DateTime.Now.Month;
                if (monthsLeft <= 0)
                    return Math.Max(TargetAmount - SavedAmount, 0);
                return Math.Max(TargetAmount - SavedAmount, 0) / monthsLeft; 
            }
        }
    }
}
