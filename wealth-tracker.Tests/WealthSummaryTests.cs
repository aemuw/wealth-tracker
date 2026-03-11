using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wealth_tracker.Models;

namespace wealth_tracker.Tests
{
    public class WealthSummaryTests
    {
        [Fact]
        public void Calculate_CorrectBalance()
        {
            var transactions = new List<Transaction>
            {
                new Transaction { Amount = 10000, Type = TransactionType.Income, Category = "Зарплата", Date = DateTime.Now },
                new Transaction { Amount = 2000, Type = TransactionType.Expense, Category = "Їжа", Date = DateTime.Now }
            };

            var summary = WealthSummary.Calculate(transactions);

            Assert.Equal(8000, summary.Balance);
            Assert.Equal(10000, summary.TotalIncome);
            Assert.Equal(2000, summary.TotalExpenses);
            Assert.Equal(2, summary.TransactionCount);
        }

        [Fact]
        public void Calculate_EmptyList_ReturnsZeros()
        {
            var transactions = new List<Transaction>();

            var summary = WealthSummary.Calculate(transactions);

            Assert.Equal(0, summary.Balance);
            Assert.Equal(0, summary.TotalIncome);
            Assert.Equal(0, summary.TotalExpenses);
            Assert.Equal(0, summary.TransactionCount);
        }

        [Fact]
        public void Calculate_NegativeBalance_WhenExpensesExceedIncome()
        {
            var transactions = new List<Transaction>
            {
                new Transaction { Amount = 500, Type = TransactionType.Income, Category = "Інше", Date = DateTime.Now },
                new Transaction { Amount = 1000, Type = TransactionType.Expense, Category = "Їжа", Date = DateTime.Now }
            };

            var summary = WealthSummary.Calculate(transactions);

            Assert.Equal(-500, summary.Balance);
        }

        [Theory]
        [InlineData(1000, 500, 500)]
        [InlineData(5000, 3000, 2000)]
        [InlineData(100, 100, 0)]
        public void Calculate_Balance_IsCorrect(decimal income, decimal expense, decimal expected)
        {
            var transactions = new List<Transaction>
            {
                new Transaction {Amount = income, Type = TransactionType.Income, Category = "x", Date = DateTime.Now },
                new Transaction {Amount = expense, Type = TransactionType.Expense, Category = "x", Date = DateTime.Now }

            };

            var summary = WealthSummary.Calculate(transactions);

            Assert.Equal(expected, summary.Balance);
        }
    }
}
