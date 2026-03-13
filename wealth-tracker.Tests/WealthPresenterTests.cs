using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using wealth_tracker.Models;
using wealth_tracker.Presenter;
using wealth_tracker.Services;

namespace wealth_tracker.Tests
{
    public class WealthPresenterTests
    {
        private Mock<IWealthView> _mockView;
        private TransactionService _service;
        private EfPersistenceService _persistence;
        private WealthPresenter _presenter;

        public WealthPresenterTests()
        {
            _mockView = new Mock<IWealthView>();
            _service = new TransactionService();
            _persistence = new EfPersistenceService();
            _presenter = new WealthPresenter(_mockView.Object, _service, _persistence);
        }

        [Fact]
        public async Task OnTransactionAdd_ValidTransaction_CallsShowSuccess()
        {
            var transaction = new Transaction
            {
                Date = DateTime.Now,
                Category = "Їжа",
                Amount = 500,
                Type = TransactionType.Expense
            };

            _mockView.Raise(v => v.TransactionAddRequested += null, this, transaction);
            await Task.Delay(100);

            _mockView.Verify(v => v.ShowSuccess(It.IsAny<string>()), Times.Once);
            _mockView.Verify(v => v.ClearAddForm(), Times.Once);
        }

        [Fact]
        public void OnTransactionDelete_ExistingTransaction_CallaShowSuccess()
        {
            var transaction = new Transaction
            {
                Date = DateTime.Now,
                Category = "Їжа",
                Amount = 500,
                Type = TransactionType.Expense
            };
            _service.Add(transaction);

            _mockView.Raise(v => v.TransactionDeleteRequested += null, this, transaction.Id);

            _mockView.Verify(v => v.ShowSuccess(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void OnTransactionDelete_NonExisting_CallsShowError()
        {
            _mockView.Raise(v => v.TransactionDeleteRequested += null, this, Guid.NewGuid());

            _mockView.Verify(v => v.ShowError(It.IsAny<string>()), Times.Once);
        }


    }
}
