using wealth_tracker;
using wealth_tracker.Presenter;

namespace wealth_tracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new WealthTracker());
        }
    }
}