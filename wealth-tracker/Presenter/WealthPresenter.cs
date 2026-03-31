using wealth_tracker.Models;
using wealth_tracker.Services;

namespace wealth_tracker.Presenter
{
    public class WealthPresenter
    {
        private readonly IWealthView _view;
        private readonly TransactionService _service;
        private readonly IPersistenceService _persistence;
        private readonly SavingsGoalService _savingsService;
        private readonly BudgetService _budgetService;
        private readonly ExportService _export = new ExportService();

        private TransactionFilter _currentFilter = new TransactionFilter();

        public WealthPresenter(IWealthView view, TransactionService service, IPersistenceService persistence, SavingsGoalService savingsService, BudgetService budgetService)
        {
            _view = view;
            _service = service;
            _persistence = persistence;
            _savingsService = savingsService;
            _budgetService = budgetService;

            _view.TransactionAddRequested += OnTransactionAdd;
            _view.TransactionDeleteRequested += OnTransactionDelete;
            _view.FilterChanged += OnFilterChanged;
            _view.ExportRequested += OnExport;
            _view.SaveXmlRequested += OnSaveXml;

            _view.SavingsGoalAddRequested += OnSavingsGoalAdd;
            _view.SavingsGoalDeleteRequested += OnSavingsGoalDelete;
            _view.SavingsDepositRequested += OnSavingsDeposit;

            _view.BudgetLimitAddRequested += OnBugetLimitAdd;
            _view.BudgetLimitDeleteRequested += OnBudgetLimitDelete;
            _view.SavingsTransferRequested += OnSavingsTransfer;
            _view.ReportRequest += OnReportRequest;
        }

        public async Task InitializeAsync()
        {
            var saved = await _persistence.LoadAsync();
            foreach (var t in saved)
                _service.Add(t);

            await _savingsService.LoadAsync();
            await _budgetService.LoadAsync();

            await ProcessRecurringTransactionsAsync();
            await LoadSampleDataIfEmptyAsync();
            RefreshAll();
        }

        private async Task ProcessRecurringTransactionsAsync()
        {
            var recurring = _service.GetRecurring().ToList();

            foreach (var template in recurring)
            {
                if (_service.HasRecurringThisMonth(template))
                    continue;

                if (template.RecurringDay.HasValue && DateTime.Now.Day < template.RecurringDay.Value)
                    continue;

                var copy = new Transaction
                {
                    Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, template.RecurringDay ?? DateTime.Now.Day),
                    Category = template.Category,
                    Amount = template.Amount,
                    Type = template.Type,
                    Note = $"Автоматично (повторювана)",
                    IsRecurring = false
                };

                _service.Add(copy);
                await _persistence.SaveAsync(copy);
            }
        }

        private async void OnTransactionAdd(object? sender, Transaction transaction)
        {
            try
            {
                _service.Add(transaction);
                await _persistence.SaveAsync(transaction);
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
                await _persistence.DeleteAsync(id);
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
                await _persistence.SaveAllAsync(_service.AllTransactions);
                _view.ShowSuccess($"Збережено у БД:\n{_persistence.DbPath}");
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка збереження XML: {ex.Message}");
            }
        }

        private void RefreshAll()
        {
            var summary = _service.GetSummary();
            _budgetService.RecalculateSpent(_service.AllTransactions);

            _view.ShowSummary(summary);
            _view.ShowWalletStatus(summary.Balance);
            _view.ShowTransactions(_service.GetFiltered(_currentFilter));
            _view.ShowPieChart(_service.GetExpensesByCategory());
            _view.ShowLineChart(_service.GetBalanceTimeline());
            _view.ShowCombinedChart(_service.GetMonthlyChartData(), _service.GetForecastPoint());
            _view.ShowForecast(_service.GetMonthlyForecast());
            _view.ShowSavingsGoals(_savingsService.AllGoals);
            _view.ShowBudgetLimits(_budgetService.GetCurrentMonth());
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

            await _persistence.SaveAllAsync(_service.AllTransactions);
        }

        private async void OnSavingsGoalAdd(object? sender, SavingsGoal goal)
        {
            try
            {
                await _savingsService.AddAsync(goal);
                _view.ShowSuccess($"Ціль \"{goal.Name}\" додано!");
                RefreshAll();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка: {ex.Message}");
            }
        }

        private async void OnSavingsGoalDelete(object? sender, Guid id)
        {
            try
            {
                await _savingsService.DeleteAsync(id, _service, _persistence);
                _view.ShowSuccess("Ціль видалено! Накопичені кошти повернуто на баланс.");
                RefreshAll();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка: {ex.Message}");
            }
        }

        private async void OnSavingsDeposit(object? sender, (Guid GoalId, decimal Amount) args)
        {
            try
            {
                await _savingsService.DepositAsync(args.GoalId, args.Amount, _service, _persistence);
                _view.ShowSuccess($"Поповнено на {args.Amount:N2} ₴!");
                RefreshAll();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка: {ex.Message}");
            }
        }

        private async void OnSavingsTransfer(object? sender, (Guid FromId, Guid ToId, decimal Amount) args)
        {
            try
            {
                await _savingsService.TransferAsync(args.FromId, args.ToId, args.Amount);
                _view.ShowSuccess($"Переказано {args.Amount:N2} ₴!");
                RefreshAll();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка: {ex.Message}");
            }
        }

        private async void OnBugetLimitAdd(object? sender, BudgetLimit limit)
        {
            try
            {
                await _budgetService.AddOrUpdateAsync(limit);
                _view.ShowSuccess($"Ліміт для \"{limit.Category}\" встановлено!");
                RefreshAll();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка: {ex.Message}");
            }
        }

        private async void OnBudgetLimitDelete(object? sender, Guid id)
        {
            try
            {
                await _budgetService.DeleteAsync(id);
                _view.ShowSuccess("Ліміт видалено!");
                RefreshAll();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка: {ex.Message}");
            }
        }

        private async void OnReportRequest(object? sender, string format)
        {
            var path = _view.AskSaveFilePath(
                "PDF файл (*.pdf)|*.pdf",
                $"Звіт_{DateTime.Now:yyyy-MM}.pdf");

            if (path == null)
                return;

            try
            {
                var reportService = new ReportService();
                reportService.GeneratePdfReport(
                    _service.GetSummary(),
                    _service.AllTransactions,
                    _service.GetMonthlyForecast(),
                    _savingsService.AllGoals,
                    _budgetService.GetCurrentMonth(),
                    path);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });

                _view.ShowSuccess($"Звіт збережено:\n{path}");
            }
            catch (Exception ex)
            {
                _view.ShowError($"Помилка звіту: {ex.Message}");
            }
        }
    }
}
