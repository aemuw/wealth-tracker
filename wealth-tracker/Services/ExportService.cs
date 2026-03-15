using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class ExportService
    {
        public async Task ExportCsvAsync(IEnumerable<Transaction> transactions, string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };

            await using var writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8);
            await using var csv = new CsvWriter(writer, config);

            csv.WriteField("Дата");
            csv.WriteField("Категорія");
            csv.WriteField("Сума");
            csv.WriteField("Тип");
            await csv.NextRecordAsync();

            foreach (var t in transactions)
            {
                csv.WriteField(t.Date.ToString("dd.MM.yyyy"));
                csv.WriteField(t.Category);
                csv.WriteField(t.Amount.ToString("N2"));
                csv.WriteField(t.TypeDisplay);
                await csv.NextRecordAsync();
            }
        }
    }
}
