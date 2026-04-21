using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using wealth_tracker.Data;
using wealth_tracker.Forms;
using wealth_tracker.Presenter;
using wealth_tracker.Services;

namespace wealth_tracker
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>();
            services.AddSingleton<UserService>();
            services.AddSingleton<TransactionService>();
            services.AddSingleton<IPersistenceService, EfPersistenceService>();
            services.AddSingleton<SavingsGoalService>();
            services.AddSingleton<BudgetService>();
            services.AddSingleton<WealthTracker>();
            services.AddSingleton<IWealthView>(p => p.GetRequiredService<WealthTracker>());
            services.AddSingleton<WealthPresenter>();

            var provider = services.BuildServiceProvider();

            using (var scope = provider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                await dbContext.Database.MigrateAsync();
            }

            var userService = provider.GetRequiredService<UserService>();
            await userService.EnsureAdminExistsAsync();

            using var loginForm = new LoginForm(userService);

            if (loginForm.ShowDialog() != DialogResult.OK)
                return;

            var form = provider.GetRequiredService<WealthTracker>();
            var presenter = provider.GetRequiredService<WealthPresenter>();

            form.SetPresenter(presenter);
            form.SetUserService(userService);

            Application.Run(form);
        }
    }
}