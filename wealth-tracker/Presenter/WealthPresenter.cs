using System;
using System.Windows.Forms;
using wealth_tracker.Models;
using wealth_tracker.Services;

namespace wealth_tracker.Presenter
{
    public class WealthPresenter
    {
        private readonly IWealthView _view;
        private readonly TransactionService _service;
        private readonly PersistenceService _persistence;
        private readonly ExportService _export = new ExportService();

        private TransactionFilter _currentFilter = new TransactionFilter();

        public WealthPresenter(IWealthView view, TransactionService service, PersistenceService persistence)
        {
            _view = view;
            _service = service;
            _persistence = persistence;

            _view.TransactionAddRequested += OnTransactionAdd;
            _view.TransactionDeleteRequested += OnTransactionDelete;
            _view.FilterChanged += OnFilterChanged;
            _view.ExportRequested += OnExport;
            _view.SaveXmlRequested += OnSaveXml;
        }

        public async Task InitializeAsync()
        {
            var saved = await _persistence.LoadAsync();
            foreach (var t in saved)
                _service.Add(t);

            await LoadSampleDataIfEmptyAsync();
            RefreshAll();
        }


        private async void OnTransactionAdd(object? sender, Transaction transaction)
        {
            try
            {
                _service.Add(transaction);
                await _persistence.SaveJsonAsync(_service.AllTransactions);
                _view.ClearAddForm();
                _view.ShowSuccess("Транзакцію додано успішно!");
                RefreshAll();
            }
            catch (ArgumentException ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private async void OnTransactionDelete(object? sender, Guid id)
        {
            if (_service.Remove(id))
            {
                await _persistence.SaveJsonAsync(_service.AllTransactions); 
                _view.ShowSuccess("Транзакцію видалено!");
                RefreshAll();
            }
            else
            {
                _view.ShowError("Транзакцію не знайдено");
            }
        }

        private void OnFilterChanged(object? sender, TransactionFilter filter)
        {
            _currentFilter = filter ?? new TransactionFilter();
            _view.ShowTransactions(_service.GetFiltered(_currentFilter));
        }

        private async void OnExport(object? sender, EventArgs e)
        {
            var path = _view.AskSaveFilePath(
                "CSV файл (*.csv)|*.csv",
                $"Транзакції_{DateTime.Now:yyyy-MM-dd}.csv");

            if (path == null)
                return;
            try
            {
                await _export.ExportCsvAsync(_service.GetFiltered(_currentFilter), path);
                _view.ShowSuccess("Дані експортовано у CSV!");
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка експорту: {ex.Message}");
            }
        }

        private async void OnSaveXml(object? sender, EventArgs e)
        {
            try
            {
                await _persistence.SaveXmlAsync(_service.AllTransactions);
                _view.ShowSuccess($"Збережено у XML:\n{_persistence.XmlPath}");
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка збереження XML: {ex.Message}");
            }
        }

        private void RefreshAll()
        {
            var summary = _service.GetSummary();
            _view.ShowSummary(summary);
            _view.ShowWalletStatus(summary.Balance);
            _view.ShowTransactions(_service.GetFiltered(_currentFilter));
            _view.ShowPieChart(_service.GetExpensesByCategory());
            _view.ShowLineChart(_service.GetBalanceTimeline());
        }

        private async Task LoadSampleDataIfEmptyAsync()
        {
            if (_service.GetSummary().TransactionCount > 0) 
                return;

            _service.Add(new Transaction 
            { 
                Date = DateTime.Now.AddDays(-10), 
                Category = "Зарплата", 
                Amount = 15000, 
                Type = TransactionType.Income 
            });
            _service.Add(new Transaction 
            {
                Date = DateTime.Now.AddDays(-9), 
                Category = "Їжа", 
                Amount = 450, 
                Type = TransactionType.Expense 
            });
            _service.Add(new Transaction 
            {
                Date = DateTime.Now.AddDays(-7), 
                Category = "Транспорт", 
                Amount = 200, 
                Type = TransactionType.Expense 
            });
            _service.Add(new Transaction 
            {
                Date = DateTime.Now.AddDays(-5), 
                Category = "Комунальні", 
                Amount = 800, 
                Type = TransactionType.Expense 
            });
            _service.Add(new Transaction 
            {
                Date = DateTime.Now.AddDays(-4), 
                Category = "Розваги", 
                Amount = 350, 
                Type = TransactionType.Expense 
            });
            _service.Add(new Transaction 
            {
                Date = DateTime.Now.AddDays(-2), 
                Category = "Фріланс", 
                Amount = 3000, 
                Type = TransactionType.Income 
            });
            _service.Add(new Transaction 
            {
                Date = DateTime.Now.AddDays(-1), 
                Category = "Їжа", 
                Amount = 280, 
                Type = TransactionType.Expense
            });
            _service.Add(new Transaction 
            { 
                Date = DateTime.Now,
                Category = "Здоров'я", 
                Amount = 500, 
                Type = TransactionType.Expense 
            });

            await _persistence.SaveJsonAsync(_service.AllTransactions);
        }
    }
}
