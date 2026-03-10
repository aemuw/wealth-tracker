using wealth_tracker;
using wealth_tracker.Presenter;
using wealth_tracker.Services;

namespace wealth_tracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var service = new TransactionService();
            var persistence = new PersistenceService(default);
            var form = new WealthTracker();
            var presenter = new WealthPresenter(form, service, persistence);
            form.SetPresenter(presenter);

            Application.Run(form);
        }
    }
}