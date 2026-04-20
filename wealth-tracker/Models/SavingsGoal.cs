using System.ComponentModel.DataAnnotations;

namespace wealth_tracker.Models
{
    public class SavingsGoal
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public Guid UserId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; } = string.Empty;

        public decimal? TargetAmount { get; set; }

        public decimal SavedAmount { get; set; }

        public DateTime? Deadline { get; set; }

        public string? Note { get; set; }

        public bool AutoSave { get; set; } = false;

        public decimal? AutoSaveAmount { get; set; }
        public decimal? AutoSavePercent { get; set; }

        public DateTime? LastAutoSaveDate { get; set; }

        public decimal Progress => (TargetAmount.HasValue && TargetAmount > 0) ? Math.Min(SavedAmount / TargetAmount.Value * 100, 100) : 0;

        public bool IsCompleted => TargetAmount.HasValue && TargetAmount > 0 && SavedAmount >= TargetAmount.Value;

        public decimal MonthlyRequired
        {
            get 
            {
                if (!TargetAmount.HasValue || !Deadline.HasValue)
                    return 0;
                var monthsLeft = ((Deadline.Value.Year - DateTime.Now.Year) * 12) + Deadline.Value.Month - DateTime.Now.Month;
                if (monthsLeft <= 0)
                    return Math.Max(TargetAmount.Value - SavedAmount, 0);
                return Math.Max(TargetAmount.Value - SavedAmount, 0) / monthsLeft;
            }
        }

        public string TargetDisplay => TargetAmount.HasValue ? $"{TargetAmount:N2} ₴" : "Накопичення";

        public string DeadlineDisplay => Deadline.HasValue ? Deadline.Value.ToString("dd.MM.yyyy") : "-";
    }
}
