using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public class ReportService
    {
        public void GeneratePdfReport(
            WealthSummary summary,
            IEnumerable<Transaction> transactions,
            decimal forecast,
            IReadOnlyList<SavingsGoal> goals,
            List<BudgetLimit> budgetLimits,
            string path)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(11));

                    page.Header()
                        .Text($"WealthTracker — Звіт {DateTime.Now:MMMM yyyy}")
                        .SemiBold().FontSize(18).FontColor(Colors.Blue.Medium);

                    page.Content().Column(col =>
                    {
                        col.Spacing(12);

                        col.Item().Text("Підсумок місяця")
                            .SemiBold().FontSize(14);

                        col.Item().Row(row =>
                        {
                            row.Spacing(8);
                            SummaryCard(row.RelativeItem(), "Доходи",
                                $"{summary.TotalIncome:N2} ₴", Colors.Green.Medium);
                            SummaryCard(row.RelativeItem(), "Витрати",
                                $"{summary.TotalExpenses:N2} ₴", Colors.Red.Medium);
                            SummaryCard(row.RelativeItem(), "Баланс",
                                $"{summary.Balance:N2} ₴", Colors.Blue.Medium);
                            SummaryCard(row.RelativeItem(), "Прогноз",
                                $"{forecast:N2} ₴", Colors.Orange.Medium);
                        });

                        if (budgetLimits.Any())
                        {
                            col.Item().Text("Бюджет по категоріях")
                                .SemiBold().FontSize(14);

                            col.Item().Table(table =>
                            {
                                table.ColumnsDefinition(c =>
                                {
                                    c.RelativeColumn(3);
                                    c.RelativeColumn(2);
                                    c.RelativeColumn(2);
                                    c.RelativeColumn(2);
                                });

                                table.Header(header =>
                                {
                                    foreach (var h in new[] { "Категорія", "Ліміт", "Витрачено", "Залишок" })
                                        header.Cell()
                                            .Background(Colors.Blue.Medium)
                                            .Padding(5)
                                            .Text(h).FontColor(Colors.White).SemiBold();
                                });

                                foreach (var b in budgetLimits)
                                {
                                    var color = b.IsExceeded ? Colors.Red.Medium : Colors.Black;
                                    table.Cell().Padding(4).Text(b.Category);
                                    table.Cell().Padding(4).Text($"{b.LimitAmount:N2} ₴");
                                    table.Cell().Padding(4).Text($"{b.SpentAmount:N2} ₴").FontColor(color);
                                    table.Cell().Padding(4).Text($"{b.Remaining:N2} ₴").FontColor(color);
                                }
                            });
                        }

                        if (goals.Any())
                        {
                            col.Item().Text("Цілі заощаджень")
                                .SemiBold().FontSize(14);

                            col.Item().Table(table =>
                            {
                                table.ColumnsDefinition(c =>
                                {
                                    c.RelativeColumn(3);
                                    c.RelativeColumn(2);
                                    c.RelativeColumn(2);
                                    c.RelativeColumn(1);
                                    c.RelativeColumn(2);
                                });

                                table.Header(header =>
                                {
                                    foreach (var h in new[] { "Назва", "Ціль", "Накопичено", "%", "Дедлайн" })
                                        header.Cell()
                                            .Background(Colors.Blue.Medium)
                                            .Padding(5)
                                            .Text(h).FontColor(Colors.White).SemiBold();
                                });

                                foreach (var g in goals)
                                {
                                    var color = g.IsCompleted ? Colors.Green.Medium : Colors.Black;
                                    table.Cell().Padding(4).Text(g.Name);
                                    table.Cell().Padding(4).Text($"{g.TargetAmount:N2} ₴");
                                    table.Cell().Padding(4).Text($"{g.SavedAmount:N2} ₴").FontColor(color);
                                    table.Cell().Padding(4).Text($"{g.Progress:F0}%").FontColor(color);
                                    table.Cell().Padding(4).Text(g.TargetDisplay);
                                    table.Cell().Padding(4).Text(g.DeadlineDisplay);
                                }
                            });
                        }

                        col.Item().Text("Транзакції")
                            .SemiBold().FontSize(14);

                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(c =>
                            {
                                c.RelativeColumn(2);
                                c.RelativeColumn(3);
                                c.RelativeColumn(2);
                                c.RelativeColumn(2);
                            });

                            table.Header(header =>
                            {
                                foreach (var h in new[] { "Дата", "Категорія", "Тип", "Сума" })
                                    header.Cell()
                                        .Background(Colors.Blue.Medium)
                                        .Padding(5)
                                        .Text(h).FontColor(Colors.White).SemiBold();
                            });

                            foreach (var t in transactions.OrderByDescending(x => x.Date))
                            {
                                var color = t.Type == TransactionType.Income
                                    ? Colors.Green.Medium
                                    : Colors.Red.Medium;
                                var sign = t.Type == TransactionType.Income ? "+" : "−";

                                table.Cell().Padding(4).Text(t.Date.ToString("dd.MM.yyyy"));
                                table.Cell().Padding(4).Text(t.Category);
                                table.Cell().Padding(4).Text(t.TypeDisplay).FontColor(color);
                                table.Cell().Padding(4).Text($"{sign}{t.Amount:N2} ₴").FontColor(color);
                            }
                        });
                    });

                    page.Footer()
                        .AlignCenter()
                        .Text($"Сформовано {DateTime.Now:dd.MM.yyyy HH:mm}")
                        .FontSize(9).FontColor(Colors.Grey.Medium);
                });
            }).GeneratePdf(path);
        }

        private static void SummaryCard(
            IContainer container, string label, string value, string color)
        {
            container
                .Border(1).BorderColor(Colors.Grey.Lighten2)
                .Padding(8)
                .Column(c =>
                {
                    c.Item().Text(label).FontSize(9).FontColor(Colors.Grey.Medium);
                    c.Item().Text(value).SemiBold().FontColor(color);
                });
        }
    }
}