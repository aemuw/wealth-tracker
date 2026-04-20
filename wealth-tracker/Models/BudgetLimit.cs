using System;
using System.ComponentModel.DataAnnotations;

namespace wealth_tracker.Models
{
    public class BudgetLimit
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public Guid UserId { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal LimitAmount { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }

        public decimal SpentAmount { get; set; }

        public decimal Remaining => LimitAmount - SpentAmount;
        public bool IsExceeded => SpentAmount > LimitAmount;

        public decimal DailyAllowance
        {
            get
            {
                var daysLeft = DateTime.DaysInMonth(Year, Month) - DateTime.Now.Day;
                return daysLeft > 0 ? Math.Max(Remaining / daysLeft, 0) : 0;
            }
        }
    }
}
