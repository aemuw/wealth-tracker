using wealth_tracker;
using Microsoft.Extensions.DependencyInjection;
using wealth_tracker.Presenter;
using wealth_tracker.Services;
using wealth_tracker.Data;
using Microsoft.EntityFrameworkCore;

namespace wealth_tracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>();
            services.AddSingleton<TransactionService>();
            services.AddSingleton<IPersistenceService, EfPersistenceService>();
            services.AddSingleton<WealthTracker>();
            services.AddSingleton<IWealthView>(provider => provider.GetRequiredService<WealthTracker>());
            services.AddSingleton<WealthPresenter>();

            var provider = services.BuildServiceProvider();

            var form = provider.GetRequiredService<WealthTracker>();
            var presenter = provider.GetRequiredService<WealthPresenter>();
            form.SetPresenter(presenter);

            Application.Run(form);
        }
    }
}