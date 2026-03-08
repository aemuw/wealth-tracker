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

        public WealthSummary GetSummary() => WealthSummary.Calculate(_transactions);

        public Dictionary<string, decimal> GetExpensesByCategory() => _transactions
            .Where(c => c.Type == TransactionType.Expense).GroupBy(c => c.Category)
            .ToDictionary(v => v.Key, v => v.Sum(c => c.Amount));

        public List<(DateTime Date, decimal Balance)> GetBalanceTimeline()
        {
            decimal running = 0;
            var result = new List<(DateTime, decimal)>();

            foreach (var t in _transactions.OrderBy(c => c.Date))
            {
                running += t.Type == TransactionType.Income ? t.Amount : -t.Amount;
                result.Add((t.Date.Date, running));   
            }
            return result;
        }
    }
}
