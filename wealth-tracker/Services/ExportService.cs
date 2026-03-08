using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class ExportService
    {
        public void ExportCsv(IEnumerable<Transaction> transactions, string filePath)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Дата;Категорія;Сума;Тип");

            foreach (var t in transactions)
                csv.AppendLine($"{t.Date:dd.MM.yyyy};{t.Category};{t.Amount:N2};{t.TypeDisplay}");

            File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
        }
    }
}
