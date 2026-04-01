using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class TransactionService
    {
        private readonly BindingList<Transaction> _transactions = new BindingList<Transaction>();

        public IBindingList Transactions => _transactions;
        public IEnumerable<Transaction> AllTransactions => _transactions;

        public void Add(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));
            _transactions.Add(transaction);
        }

        public bool Remove(Guid id)
        {
            var item = _transactions.FirstOrDefault(c => c.Id == id);
            if (item == null)
                return false;
            _transactions.Remove(item);
            return true;
        }

        public void Clear() => _transactions.Clear();

        public IReadOnlyList<Transaction> GetFiltered(TransactionFilter filter)
        {
            IEnumerable<Transaction> query = _transactions;

            if (!string.IsNullOrEmpty(filter?.SearchText))
                query = query.Where(c => c.Category.IndexOf(filter.SearchText, StringComparison.OrdinalIgnoreCase) >= 0);

            if (filter?.DateFrom.HasValue == true)
                query = query.Where(c => c.Date.Date >= filter.DateFrom.Value.Date);

            if (filter?.DateTo.HasValue == true)
                query = query.Where(c => c.Date.Date <= filter.DateTo.Value.Date);

            if (filter?.Type.HasValue == true)
                query = query.Where(c => c.Type == filter.Type.Value);

            return query.OrderByDescending(c => c.Date).ToList();
        }

        public WealthSummary GetSummary(decimal totalSaved = 0) => WealthSummary.Calculate(_transactions, totalSaved);

        public Dictionary<string, decimal> GetExpensesByCategory() => _transactions
            .Where(c => c.Type == TransactionType.Expense).GroupBy(c => c.Category)
            .ToDictionary(v => v.Key, v => v.Sum(c => c.Amount));

        public List<(DateTime Date, decimal Balance)> GetBalanceTimeline()
        {
            decimal running = 0;
            var result = new List<(DateTime, decimal)>();

            var grouped = _transactions.OrderBy(c => c.Date).GroupBy(c => c.Date.Date);

            foreach (var group in grouped)
            {
                foreach (var t in group)
                    running += t.Type == TransactionType.Income ? t.Amount : -t.Amount;

                result.Add((group.Key, running));
            }
            return result;
        }

        public decimal GetMonthlyForecast(decimal totalSaved = 0)
        {
            var now = DateTime.Now;
            var currentBalance = GetSummary(totalSaved).Balance;

            var monthlyExpenses = _transactions
                .Where(t => t.Type == TransactionType.Expense
                         && t.Date.Month == now.Month
                         && t.Date.Year == now.Year)
                .Sum(t => t.Amount);

            var daysPassed = now.Day;
            if (daysPassed == 0) 
                return currentBalance;

            var avgPerDay = monthlyExpenses / daysPassed;
            var daysLeft = DateTime.DaysInMonth(now.Year, now.Month) - now.Day;

            return currentBalance - avgPerDay * daysLeft;
        }

        public List<(string Label, decimal Income, decimal Expense, decimal Balance)> GetMonthlyChartData()
        {
            var now = DateTime.Now;
            var result = new List<(string, decimal, decimal, decimal)>();
            decimal runningBalance = 0;

            for (int i = 5; i >= 0; i--)
            {
                var date = now.AddMonths(-i);
                var label = date.ToString("MMM yyyy");

                var income = _transactions
                    .Where(t =>
                    t.Type == TransactionType.Income &&
                    t.Date.Month == date.Month &&
                    t.Date.Year == date.Year)
                    .Sum(t => t.Amount);

                var expense = _transactions
                    .Where(t =>
                    t.Type == TransactionType.Expense &&
                    t.Date.Month == date.Month &&
                    t.Date.Year == date.Year)
                    .Sum(t => t.Amount);

                runningBalance += income - expense;
                result.Add((label, income, expense, runningBalance));
            }
            return result;
        }

        public (string Label, decimal ForecastBalance) GetForecastPoint(decimal totalSaved = 0)
        {
            var now = DateTime.Now;
            var daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            var forecast = GetMonthlyForecast(totalSaved);
            var label = new DateTime(now.Year, now.Month, daysInMonth).ToString("MMM yyyy") + "*";
            return (label, forecast);
        }

        public IEnumerable<Transaction> GetRecurring()
            => _transactions.Where(t => t.IsRecurring);

        public bool HasRecurringThisMonth(Transaction template)
            => _transactions.Any(t =>
            t.Category == template.Category &&
            t.Amount == template.Amount &&
            t.Type == template.Type &&
            t.Date.Month == DateTime.Now.Month &&
            t.Date.Year == DateTime.Now.Year &&
            !t.IsRecurring);
    }   
}
