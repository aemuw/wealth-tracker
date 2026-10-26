using wealth_tracker.Models;
using wealth_tracker.Services;

namespace wealth_tracker.Tests;

public class BoundaryAndExceptionTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-0.01)]
    [InlineData(-100)]
    public void Amount_NonPositive_ThrowsArgumentException(decimal amount)
    {
        // Arrange
        var transaction = new Transaction { Amount = 100m };

        // Act and Assert
        Assert.Throws<ArgumentException>(() => transaction.Amount = amount);
        Assert.Equal(100m, transaction.Amount);
    }

    [Fact]
    public void Amount_OneKopiyka_IsAccepted()
    {
        // Arrange
        var service = new TransactionService();
        var transaction = new Transaction
        {
            Category = "Їжа", Date = new DateTime(2026, 10, 1),
            Amount = 0.01m, Type = TransactionType.Expense
        };

        // Act
        service.Add(transaction);
        var summary = service.GetSummary();

        // Assert
        Assert.Equal(0.01m, summary.TotalExpenses);
        Assert.Equal(-0.01m, summary.Balance);
        Assert.Equal(1, summary.TransactionCount);
    }

    [Fact]
    public void Add_Null_ThrowsArgumentNullException_AndKeepsState()
    {
        // Arrange
        var service = new TransactionService();

        // Act and Assert
        var exception = Assert.Throws<ArgumentNullException>(
            () => service.Add(null!));
        Assert.Equal("transaction", exception.ParamName);
        Assert.Empty(service.AllTransactions);
    }

    [Fact]
    public void GetFiltered_DateRange_IncludesBothBoundaryDates()
    {
        // Arrange
        var service = new TransactionService();
        var first = new DateTime(2026, 10, 10);
        var last = new DateTime(2026, 10, 20);
        var before = new Transaction { Date = first.AddDays(-1),
            Category = "Їжа", Amount = 1m, Type = TransactionType.Expense };
        var start = new Transaction { Date = first,
            Category = "Їжа", Amount = 2m, Type = TransactionType.Expense };
        var end = new Transaction { Date = last.AddHours(23),
            Category = "Їжа", Amount = 3m, Type = TransactionType.Expense };
        var after = new Transaction { Date = last.AddDays(1),
            Category = "Їжа", Amount = 4m, Type = TransactionType.Expense };
        foreach (var transaction in new[] { before, start, end, after })
            service.Add(transaction);

        // Act
        var result = service.GetFiltered(
            new TransactionFilter(dateFrom: first, dateTo: last));

        // Assert: descending date order, both boundary dates included.
        Assert.Equal(new[] { end.Id, start.Id }, result.Select(t => t.Id));
    }
}
