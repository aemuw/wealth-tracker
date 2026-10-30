using Microsoft.Data.Sqlite;

namespace wealth_tracker.Data;

public static class AppDataPaths
{
    private static readonly Lazy<string> Database = new(PrepareDatabase);
    public static string DatabasePath => Database.Value;

    private static string PrepareDatabase()
    {
        string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WealthTracker");
        Directory.CreateDirectory(directory);
        string destination = Path.Combine(directory, "wealth-tracker.db");
        if (File.Exists(destination)) return destination;

        // Preserve a database from an earlier portable build, including its WAL.
        string? previous = new[]
        {
            Path.Combine(AppContext.BaseDirectory, "wealth-tracker.db"),
            Path.Combine(Environment.CurrentDirectory, "wealth-tracker.db")
        }.FirstOrDefault(path => !Path.GetFullPath(path).Equals(destination, StringComparison.OrdinalIgnoreCase) && File.Exists(path));
        if (previous == null) return destination;

        string temporary = destination + ".migrating_" + Guid.NewGuid().ToString("N");
        try
        {
            using (var source = new SqliteConnection(new SqliteConnectionStringBuilder
                { DataSource = previous, Mode = SqliteOpenMode.ReadOnly }.ToString()))
            using (var target = new SqliteConnection(new SqliteConnectionStringBuilder
                { DataSource = temporary, Pooling = false }.ToString()))
            {
                source.Open();
                target.Open();
                source.BackupDatabase(target);
            }
            File.Move(temporary, destination, overwrite: false);
        }
        finally
        {
            if (File.Exists(temporary)) File.Delete(temporary);
        }
        return destination;
    }
}
