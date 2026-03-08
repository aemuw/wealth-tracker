using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static WealthSummary Calculate(IEnumerable<Transaction> transactions)
        {
            var list = transactions.ToList();
            var income = list.Where(c => c.Type == TransactionType.Income).Sum(c => c.Amount);
            var expenses = list.Where(c => c.Type == TransactionType.Expense).Sum(c => c.Amount);

            return new WealthSummary
            (
                balance: income - expenses,
                totalIncome: income,
                totalExpenses: expenses,
                count: list.Count
            );
        }
    }
}
