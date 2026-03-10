using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wealth_tracker.Models;
using wealth_tracker.Services;

namespace wealth_tracker.Tests
{
    public class TransactionServiceTests
    {
        private TransactionService CreateService() => new TransactionService();

        [Fact]
        public void Add_ValidTransaction_IncreasesCount()
        {
            var service = CreateService();
            var transaction = new Transaction
            {
                Date = DateTime.Now,
                Category = "Їжа",
                Amount = 500,
                Type = TransactionType.Expense
            };

            service.Add(transaction);
            Assert.Equal(1, service.GetSummary().TransactionCount);


        }

        [Fact]
        public void GetSummary_CorrectBalance()
        {
            var service = CreateService();
            service.Add(new Transaction { Amount = 15000, Type = TransactionType.Income, Category = "Зарплата", Date = DateTime.Now });
            service.Add(new Transaction { Amount = 500, Type = TransactionType.Expense, Category = "Їжа", Date = DateTime.Now });

            var summary = service.GetSummary();

            Assert.Equal(14500, summary.Balance);
            Assert.Equal(15000, summary.TotalIncome);
            Assert.Equal(500, summary.TotalExpenses);
            Assert.Equal(2, summary.TransactionCount);
        }

        [Fact]
        public void Remove_ExistingTransaction_ReturnsTrue()
        {
            var service = CreateService();
            var transaction = new Transaction { Amount = 500, Type = TransactionType.Expense, Category = "Їжа", Date = DateTime.Now };
            service.Add(transaction);

            var result = service.Remove(transaction.Id);

            Assert.True(result);
            Assert.Equal(0, service.GetSummary().TransactionCount);
        }

        [Fact]
        public void Remove_NonExistingTransaction_ReturnsFalse()
        {
            var service = CreateService();

            var result = service.Remove(Guid.NewGuid());

            Assert.False(result);
        }

        [Fact]
        public void GetFiltered_BySearchText_ReturnsCorrect()
        {
            var service = CreateService();
            service.Add(new Transaction { Amount = 500, Type = TransactionType.Expense, Category = "Їжа", Date = DateTime.Now});
            service.Add(new Transaction { Amount = 200, Type = TransactionType.Expense, Category = "Транспорт", Date = DateTime.Now });

            var result = service.GetFiltered(new TransactionFilter(searchText: "Їжа"));

            Assert.Single(result);
            Assert.Equal("Їжа", result[0].Category);
        }
    }
}
