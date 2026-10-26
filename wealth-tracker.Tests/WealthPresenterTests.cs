using Microsoft.EntityFrameworkCore;
using Moq;
using wealth_tracker.Data;
using wealth_tracker.Models;
using wealth_tracker.Presenter;
using wealth_tracker.Services;

namespace wealth_tracker.Tests;

public class WealthPresenterTests : IDisposable
{
    private readonly Mock<IWealthView> _view = new();
    private readonly Mock<IPersistenceService> _persistence = new();
    private readonly TransactionService _service = new();
    private readonly AppDbContext _context;
    private readonly WealthPresenter _presenter;

    public WealthPresenterTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
        _context = new AppDbContext(options);
        _persistence.Setup(p => p.SaveAsync(It.IsAny<Transaction>()))
            .Returns(Task.CompletedTask);
        _persistence.Setup(p => p.DeleteAsync(It.IsAny<Guid>()))
            .Returns(Task.CompletedTask);
        _presenter = new WealthPresenter(_view.Object, _service,
            _persistence.Object, new SavingsGoalService(_context),
            new BudgetService(_context), new UserService(_context));
    }

    [Fact]
    public async Task OnTransactionAdd_ValidTransaction_CallsShowSuccess()
    {
        // Arrange: ShowSummary is called after persistence and notification.
        var refreshed = new TaskCompletionSource<WealthSummary>(
            TaskCreationOptions.RunContinuationsAsynchronously);
        _view.Setup(v => v.ShowSummary(It.IsAny<WealthSummary>()))
            .Callback<WealthSummary>(s => refreshed.TrySetResult(s));
        var transaction = new Transaction
        {
            Date = new DateTime(2026, 10, 1), Category = "Їжа",
            Amount = 500m, Type = TransactionType.Expense
        };

        // Act
        _view.Raise(v => v.TransactionAddRequested += null, this, transaction);
        var summary = await refreshed.Task.WaitAsync(TimeSpan.FromSeconds(5));

        // Assert
        Assert.Equal(1, summary.TransactionCount);
        Assert.Equal(-500m, summary.Balance);
        _persistence.Verify(p => p.SaveAsync(transaction), Times.Once);
        _view.Verify(v => v.ShowSuccess(It.IsAny<string>()), Times.Once);
        _view.Verify(v => v.ClearAddForm(), Times.Once);
        _view.Verify(v => v.ShowError(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public async Task OnTransactionDelete_ExistingTransaction_CallsShowSuccess()
    {
        // Arrange
        var transaction = new Transaction
        {
            Date = new DateTime(2026, 10, 1), Category = "Їжа",
            Amount = 500m, Type = TransactionType.Expense
        };
        _service.Add(transaction);
        var refreshed = new TaskCompletionSource<WealthSummary>(
            TaskCreationOptions.RunContinuationsAsynchronously);
        _view.Setup(v => v.ShowSummary(It.IsAny<WealthSummary>()))
            .Callback<WealthSummary>(s => refreshed.TrySetResult(s));

        // Act
        _view.Raise(v => v.TransactionDeleteRequested += null,
            this, transaction.Id);
        var summary = await refreshed.Task.WaitAsync(TimeSpan.FromSeconds(5));

        // Assert
        Assert.Equal(0, summary.TransactionCount);
        Assert.Empty(_service.AllTransactions);
        _persistence.Verify(p => p.DeleteAsync(transaction.Id), Times.Once);
        _view.Verify(v => v.ShowSuccess(It.IsAny<string>()), Times.Once);
        _view.Verify(v => v.ShowError(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void OnTransactionDelete_NonExisting_CallsShowError()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        _view.Raise(v => v.TransactionDeleteRequested += null, this, id);

        // Assert
        Assert.Empty(_service.AllTransactions);
        _view.Verify(v => v.ShowError(It.IsAny<string>()), Times.Once);
        _persistence.Verify(p => p.DeleteAsync(It.IsAny<Guid>()), Times.Never);
        _view.Verify(v => v.ShowSuccess(It.IsAny<string>()), Times.Never);
    }

    public void Dispose() => _context.Dispose();
}
