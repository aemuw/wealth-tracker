using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using wealth_tracker.Models;
using wealth_tracker.Services;
using wealth_tracker.Presenter;

namespace wealth_tracker
{
    public partial class WealthTracker : Form, IWealthView
    {
        private WealthPresenter? _presenter;

        public event EventHandler<Transaction> TransactionAddRequested = delegate { };
        public event EventHandler<Guid> TransactionDeleteRequested = delegate { };
        public event EventHandler<TransactionFilter> FilterChanged = delegate { };
        public event EventHandler ExportRequested = delegate { };
        public event EventHandler SaveXmlRequested = delegate { };

        private static readonly string[] _expenseCategories =
        {
            "Їжа", "Транспорт", "Комунальні", "Розваги", "Одяг",
            "Здоров'я", "Освіта", "Спорт", "Подарунки", "Інше"
        };

        private static readonly string[] _incomeCategories =
        {
            "Зарплата", "Фріланс", "Бізнес", "Інвестиції",
            "Подарунок", "Продаж", "Бонус", "Інше"
        };

        public WealthTracker()
        {
            InitializeComponent();
        }

        private void WealthTracker_Load(object sender, EventArgs e)
        {
            this.Text = "WealthTracker";

            var service     = new TransactionService();
            var persistence = new PersistenceService("default");
            _presenter = new WealthPresenter(this, service, persistence);

            InitializeDataGrid();
            InitializePieChart();
            InitializeLineChart();
            InitializeCategoryComboBox();

            _presenter.Initialize();
        }

        public void ShowSummary(WealthSummary summary)
        {
            labelBalance.Text = $"Баланс\n{summary.Balance:N2} ₴";
            labelTotalIncome.Text = $"Доходи\n{summary.TotalIncome:N2} ₴";
            labelTotalExpenses.Text = $"Витрати\n{summary.TotalExpenses:N2} ₴";
            labelTransactionCount.Text = $"Транзакцій: {summary.TransactionCount}";

            labelBalance.ForeColor = summary.Balance >= 0 ? Color.FromArgb(39, 174, 96) : Color.FromArgb(192, 57, 43);
        }

        public void ShowTransactions(IReadOnlyList<Transaction> transactions)
        {
            dataGridViewTransactions.DataSource = null;
            dataGridViewTransactions.DataSource = new System.ComponentModel.BindingList<Transaction>(new List<Transaction>(transactions));

            foreach (DataGridViewRow row in dataGridViewTransactions.Rows)
                if (row.DataBoundItem is Transaction t)
                    row.DefaultCellStyle.ForeColor = t.Type == TransactionType.Income ? Color.FromArgb(39, 174, 96) : Color.FromArgb(192, 57, 43);
        }

        public void ShowPieChart(Dictionary<string, decimal> expensesByCategory)
        {
            chartPie.Series["Витрати"].Points.Clear();

            Color[] colors =
            {
                Color.FromArgb(231, 76,  60),
                Color.FromArgb(52,  152, 219),
                Color.FromArgb(46,  204, 113),
                Color.FromArgb(241, 196, 15),
                Color.FromArgb(155, 89,  182),
                Color.FromArgb(230, 126, 34),
                Color.FromArgb(26,  188, 156),
                Color.FromArgb(149, 165, 166)
            };

            int i = 0;
            foreach (var kv in expensesByCategory)
            {
                var point = new DataPoint();
                point.SetValueXY(kv.Key, (double)kv.Value);
                point.Color = colors[i % colors.Length];
                point.LegendText = $"{kv.Key} ({kv.Value:N0}₴)";
                chartPie.Series["Витрати"].Points.Add(point);
                i++;
            }

            if (expensesByCategory.Count == 0)
            {
                var point = new DataPoint();
                point.SetValueXY("Немає витрат", 1);
                point.Color = Color.LightGray;
                chartPie.Series["Витрати"].Points.Add(point);
            }
        }

        public void ShowLineChart(List<(DateTime Date, decimal Balance)> timeline)
        {
            chartLine.Series["Баланс"].Points.Clear();
            foreach (var (date, balance) in timeline)
                chartLine.Series["Баланс"].Points.AddXY(date.ToShortDateString(), (double)balance);
        }

        public void ShowWalletStatus(decimal balance) => DrawWallet(balance);

        public void ShowError(string message) => MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public void ShowSuccess(string message) => MessageBox.Show(message, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void ClearAddForm()
        {
            comboBoxCategory.SelectedIndex = -1;
            textBoxAmount.Clear();
            radioButtonExpense.Checked = true;
            dateTimePickerTransaction.Value = DateTime.Now;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex == -1)
            { 
                ShowError("Виберіть категорію"); 
                return; 
            }

            if (!decimal.TryParse(textBoxAmount.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, 
                System.Globalization.CultureInfo.InvariantCulture, out decimal amount) || amount <= 0)
            { 
                ShowError("Введіть коректну суму (більше 0)"); 
                return; 
            }

            TransactionAddRequested.Invoke(this, new Transaction
            {
                Date = dateTimePickerTransaction.Value,
                Category = comboBoxCategory.SelectedItem?.ToString() ?? string.Empty,
                Amount = amount,
                Type = radioButtonIncome.Checked ? TransactionType.Income : TransactionType.Expense
            });
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count == 0)
            {
                ShowError("Виберіть транзакцію для видалення");
                return; 
            }

            var result = MessageBox.Show("Видалити обрану транзакцію?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && dataGridViewTransactions.SelectedRows[0].DataBoundItem is Transaction t)
                TransactionDeleteRequested.Invoke(this, t.Id);
        }

        private void btnFilter_Click(object sender, EventArgs e) => FilterChanged.Invoke(this, BuildFilter());

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            dateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerEnd.Value   = DateTime.Now;
            checkBoxFilterDate.Checked = false;
            FilterChanged.Invoke(this, new TransactionFilter());
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) => FilterChanged.Invoke(this, BuildFilter());

        private void btnExport_Click(object sender, EventArgs e) => ExportRequested.Invoke(this, EventArgs.Empty);

        private void btnSaveXml_Click(object sender, EventArgs e) => SaveXmlRequested.Invoke(this, EventArgs.Empty);

        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIncome.Checked)
            {
                comboBoxCategory.Items.Clear();
                comboBoxCategory.Items.AddRange(_incomeCategories);
            }
        }

        private void radioButtonExpense_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExpense.Checked)
            {
                comboBoxCategory.Items.Clear();
                comboBoxCategory.Items.AddRange(_expenseCategories);
            }
        }
        private TransactionFilter BuildFilter() => new TransactionFilter
        (
            searchText: textBoxSearch.Text,
            dateFrom: checkBoxFilterDate.Checked ? dateTimePickerStart.Value : (DateTime?)null,
            dateTo: checkBoxFilterDate.Checked ? dateTimePickerEnd.Value : (DateTime?)null
        );

        private void InitializeCategoryComboBox()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(_expenseCategories);
        }

        private void InitializeDataGrid()
        {
            dataGridViewTransactions.AutoGenerateColumns = false;
            dataGridViewTransactions.Columns.Clear();

            dataGridViewTransactions.EnableHeadersVisualStyles = false;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewTransactions.ColumnHeadersHeight = 40;
            dataGridViewTransactions.RowTemplate.Height = 32;
            dataGridViewTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTransactions.RowHeadersVisible = false;
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.ReadOnly = true;
            dataGridViewTransactions.GridColor = Color.FromArgb(220, 220, 220);
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            { 
                HeaderText = "Дата",
                DataPropertyName = "Date",
                DefaultCellStyle = { Format = "dd.MM.yyyy" }, 
                Width = 110 
            });
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
                { 
                HeaderText = "Категорія",
                DataPropertyName = "Category",  
                Width = 160
            });
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Сума (₴)",  
                DataPropertyName = "Amount",
                DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight }, 
                Width = 120 
            });
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Тип",     
                DataPropertyName = "TypeDisplay",
                Width = 100
            });
        }

        private void InitializePieChart()
        {
            chartPie.Series.Clear();
            chartPie.ChartAreas.Clear();
            chartPie.Legends.Clear();
            chartPie.Titles.Clear();

            var area = new ChartArea("Default");
            area.BackColor = Color.Transparent;
            area.Area3DStyle.Enable3D = true;
            area.Area3DStyle.Inclination = 15;
            chartPie.ChartAreas.Add(area);

            var legend = new Legend("Legend1");
            legend.Docking = Docking.Top;
            legend.Font = new Font("Segoe UI", 9F);
            legend.BackColor = Color.Transparent;
            legend.ForeColor = Color.FromArgb(52, 73, 94);
            chartPie.Legends.Add(legend);

            var series = new Series("Витрати");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT{P1}";
            series.LabelForeColor = Color.FromArgb(44, 62, 80);
            series.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
            chartPie.Series.Add(series);

            chartPie.Titles.Add(new Title("Витрати по категоріях")
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94)
            });
            chartPie.BackColor = Color.Transparent;
        }

        private void InitializeLineChart()
        {
            chartLine.Series.Clear();
            chartLine.ChartAreas.Clear();
            chartLine.Legends.Clear();
            chartLine.Titles.Clear();

            var area = new ChartArea("LineArea");
            area.BackColor = Color.White;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.Title = "Баланс (₴)";
            area.AxisX.Title = "Дата";
            area.AxisY.TitleFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            area.AxisX.TitleFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            chartLine.ChartAreas.Add(area);

            var series = new Series("Баланс");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.FromArgb(52, 152, 219);
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 7;
            series.MarkerColor = Color.FromArgb(41, 128, 185);
            chartLine.Series.Add(series);

            chartLine.Titles.Add(new Title("Динаміка балансу")
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94)
            });
            chartLine.BackColor = Color.Transparent;
        }

        private void DrawWallet(decimal balance)
        {
            string imageName = balance >= 5000 ? "wallet_good.png" : balance >= 0 ? "wallet_ok.png" : "wallet_bad.png";

            string imagePath = Path.Combine(Application.StartupPath, "Resources", imageName);

            if (pictureBoxWallet.Image != null)
            {
                pictureBoxWallet.Image.Dispose();
                pictureBoxWallet.Image = null;
            }

            if (File.Exists(imagePath))
            {
                pictureBoxWallet.Image = Image.FromFile(imagePath);
                pictureBoxWallet.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
        }
    }
}
