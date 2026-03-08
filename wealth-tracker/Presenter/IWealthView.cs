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

        void ShowError(string message);
        void ShowSuccess(string message);

        void ClearAddForm();

        event EventHandler<Transaction> TransactionAddRequested;
        event EventHandler<Guid> TransactionDeleteRequested;
        event EventHandler<TransactionFilter> FilterChanged;
        event EventHandler ExportRequested;
        event EventHandler SaveXmlRequested;
    }
}
