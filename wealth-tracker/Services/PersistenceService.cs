using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class PersistenceService
    {
        private readonly string _jsonPath;
        private readonly string _xmlPath;

        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public PersistenceService(string userLogin)
        {
            string safeName = string.Concat(userLogin.Split(Path.GetInvalidFileNameChars()));
            _jsonPath = $"transactions_{safeName}.json";
            _xmlPath = $"transactions_{safeName}.xml";
        }

        public string JsonPath => _jsonPath;
        public string XmlPath => _xmlPath;

        public List<Transaction> Load()
        {
            if (!File.Exists(_jsonPath))
                return new List<Transaction>();
            try
            {
                var json = File.ReadAllText(_jsonPath);
                return JsonSerializer.Deserialize<List<Transaction>>(json, _jsonOptions) ?? new List<Transaction>();
            }
            catch (JsonException ex)
            {
                System.Diagnostics.Debug.WriteLine($"[PersistenceService] JSON parse error: {ex.Message}");
                return new List<Transaction>();
            }
            catch (IOException ex)
            {
                System.Diagnostics.Debug.WriteLine($"[PersistenceService] File read error: {ex.Message}");
                return new List<Transaction>();
            }
        }

        public void SaveJson(IEnumerable<Transaction> transactions)
        {
            var json = JsonSerializer.Serialize(transactions, _jsonOptions);
            File.WriteAllText(_jsonPath, json);
        }

        public void SaveXml(IEnumerable<Transaction> transactions)
        {
            var dt = new DataTable("Transactions");
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Type", typeof(string));

            foreach(var t in transactions)
            {
                dt.Rows.Add
                (
                    t.Id.ToString(),
                    t.Date.ToString("yyyy-MM-dd"),
                    t.Category,
                    t.Amount,
                    t.TypeDisplay
                );
            }

            dt.WriteXml(_xmlPath, XmlWriteMode.WriteSchema);
        }
    }
}
