using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wealth_tracker.Models;

namespace wealth_tracker.Presenter
{
    public interface IWealthView
    {
        void ShowSummary(WealthSummary summary);
        void ShowTransactions(IReadOnlyList<Transaction> transaction);
        void ShowPieChart(Dictionary<string, decimal> expensesByCategory);
        void ShowLineChart(List<(DateTime Date, decimal Balance)> timeline);
        void ShowWalletStatus(decimal balance);
        void ShowSavingsGoals(IReadOnlyList<SavingsGoal> goals);
        void ShowForecast(decimal forecast);
        void ShowBudgetLimits(IReadOnlyList<BudgetLimit> limits);

        void ShowError(string message);
        void ShowSuccess(string message);

        string? AskSaveFilePath(string filter, string defaultFileName);

        void ClearAddForm();

        event EventHandler<Transaction> TransactionAddRequested;
        event EventHandler<Guid> TransactionDeleteRequested;
        event EventHandler<TransactionFilter> FilterChanged;
        event EventHandler ExportRequested;
        event EventHandler SaveXmlRequested;
        event EventHandler<SavingsGoal> SavingsGoalAddRequested;
        event EventHandler<Guid> SavingsGoalDeleteRequested;
        event EventHandler<(Guid GoalId, decimal Amount)> SavingsDepositRequested;
        event EventHandler<BudgetLimit> BudgetLimitAddRequested;
        event EventHandler<Guid> BudgetLimitDeleteRequested;
        event EventHandler<string> ReportRequest;
    }
}
