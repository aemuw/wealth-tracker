using System.Collections.Generic;
using System.Linq;

namespace wealth_tracker.Models
{
    public class WealthSummary
    {
        public decimal Balance { get; }
        public decimal TotalIncome { get; }
        public decimal TotalExpenses { get; }
        public int TransactionCount { get; }

        public WealthSummary(decimal balance, decimal totalIncome, decimal totalExpenses, int count)
        {
            Balance = balance;
            TotalIncome = totalIncome;
            TotalExpenses = totalExpenses;
            TransactionCount = count;
        }

        public static WealthSummary Calculate(IEnumerable<Transaction> transactions, decimal totalSaved = 0)
        {
            var list = transactions.ToList();
            var income = list.Where(c => c.Type == TransactionType.Income).Sum(c => c.Amount);
            var expenses = list.Where(c => c.Type == TransactionType.Expense).Sum(c => c.Amount);

            return new WealthSummary
            (
                balance: income - expenses - totalSaved, 
                totalIncome: income,
                totalExpenses: expenses,
                count: list.Count
            );
        }
    }
}