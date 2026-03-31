using System.Windows.Forms.DataVisualization.Charting;
using wealth_tracker.Models;
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
        public event EventHandler<SavingsGoal> SavingsGoalAddRequested = delegate { };
        public event EventHandler<Guid> SavingsGoalDeleteRequested = delegate { };
        public event EventHandler<(Guid GoalId, decimal Amount)> SavingsDepositRequested = delegate { };
        public event EventHandler<BudgetLimit> BudgetLimitAddRequested = delegate { };
        public event EventHandler<Guid> BudgetLimitDeleteRequested = delegate { };
        public event EventHandler<string> ReportRequest = delegate { };

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

        public void SetPresenter(WealthPresenter presenter)
        {
            _presenter = presenter;
        }

        private async void WealthTracker_Load(object sender, EventArgs e)
        {
            this.Text = "WealthTracker";
            InitializeDataGrid();
            InitializePieChart();
            InitializeLineChart();
            InitializeCategoryComboBox();

            await _presenter!.InitializeAsync();
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

        public string? AskSaveFilePath(string filter, string defaultFileName)
        {
            using var dialog = new SaveFileDialog();
            dialog.Filter = filter;
            dialog.FileName = defaultFileName;
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }

        public void ClearAddForm()
        {
            textBoxNote.Clear();
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
                Type = radioButtonIncome.Checked ? TransactionType.Income : TransactionType.Expense,
                Note = string.IsNullOrWhiteSpace(textBoxNote.Text) ? null : textBoxNote.Text.Trim() // ← ДОДАЙ
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
            comboBoxBudgetCategory.Items.Clear();
            comboBoxBudgetCategory.Items.AddRange(_expenseCategories);
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
            dataGridViewTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Нотатка",
                DataPropertyName = "Note",
                Width = 200
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

            var area = new ChartArea("CombinedArea");
            area.BackColor = Color.White;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.Title = "Сума (₴)";
            area.AxisX.Title = "Місяць";
            area.AxisY.TitleFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            area.AxisX.TitleFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartLine.ChartAreas.Add(area);

            var incSeries = new Series("Доходи");
            incSeries.ChartType = SeriesChartType.Column;
            incSeries.Color = Color.FromArgb(46, 204, 113);
            incSeries.IsValueShownAsLabel = false;
            chartLine.Series.Add(incSeries);

            var expSeries = new Series("Витрати");
            expSeries.ChartType = SeriesChartType.Column;
            expSeries.Color = Color.FromArgb(231, 76, 60);
            expSeries.IsValueShownAsLabel = false;
            chartLine.Series.Add(expSeries);

            var balSeries = new Series("Баланс");
            balSeries.ChartType = SeriesChartType.Line;
            balSeries.Color = Color.FromArgb(52, 152, 219);
            balSeries.BorderWidth = 3;
            balSeries.MarkerStyle = MarkerStyle.Circle;
            balSeries.MarkerSize = 8;
            balSeries.MarkerColor = Color.FromArgb(41, 128, 185);
            chartLine.Series.Add(balSeries);

            var forecastSeries = new Series("Прогноз");
            forecastSeries.ChartType = SeriesChartType.Line;
            forecastSeries.Color = Color.FromArgb(243, 156, 18);
            forecastSeries.BorderWidth = 2;
            forecastSeries.BorderDashStyle = ChartDashStyle.Dash;
            forecastSeries.MarkerStyle = MarkerStyle.Diamond;
            forecastSeries.MarkerSize = 8;
            chartLine.Series.Add(forecastSeries);

            var legend = new Legend("Legend");
            legend.Docking = Docking.Bottom;
            legend.Font = new Font("Segoe UI", 9F);
            legend.BackColor = Color.Transparent;
            chartLine.Legends.Add(legend);

            chartLine.Titles.Add(new Title("Доходи / Витрати / Баланс по місяцях")
            {
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
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

        public void ShowForecast(decimal forecast)
        {
            labelForecast.Text = $"Прогноз на кінець місяця\n{forecast:N2} ₴";
            labelForecast.ForeColor = forecast >= 0 ? Color.FromArgb(39, 174, 96) : Color.FromArgb(192, 57, 43);
        }

        public void ShowSavingsGoals(IReadOnlyList<SavingsGoal> goals)
        {
            if (dataGridViewSavings.Columns.Count == 0)
                InitializeSavingsGrid();

            dataGridViewSavings.DataSource = null;
            dataGridViewSavings.DataSource = new System.ComponentModel.BindingList<SavingsGoal>(
                new List<SavingsGoal>(goals));

            foreach (DataGridViewRow row in dataGridViewSavings.Rows)
                if (row.DataBoundItem is SavingsGoal g)
                    row.DefaultCellStyle.BackColor = g.IsCompleted
                        ? Color.FromArgb(212, 239, 223)
                        : Color.White;
        }

        public void ShowBudgetLimits(IReadOnlyList<BudgetLimit> limits)
        {
            if (dataGridViewBudget.Columns.Count == 0)
                InitializeBudgetGrid();

            dataGridViewBudget.DataSource = null;
            dataGridViewBudget.DataSource = new System.ComponentModel.BindingList<BudgetLimit>(
                new List<BudgetLimit>(limits));

            foreach (DataGridViewRow row in dataGridViewBudget.Rows)
                if (row.DataBoundItem is BudgetLimit b)
                    row.DefaultCellStyle.BackColor = b.IsExceeded
                        ? Color.FromArgb(250, 219, 216)
                        : Color.White;
        }

        private void InitializeSavingsGrid()
        {
            dataGridViewSavings.AutoGenerateColumns = false;
            dataGridViewSavings.EnableHeadersVisualStyles = false;
            dataGridViewSavings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewSavings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewSavings.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewSavings.ColumnHeadersHeight = 40;
            dataGridViewSavings.RowTemplate.Height = 32;

            dataGridViewSavings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Назва", DataPropertyName = "Name" });
            dataGridViewSavings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ціль (₴)", DataPropertyName = "TargetAmount", DefaultCellStyle = { Format = "N2" } });
            dataGridViewSavings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Накопичено (₴)", DataPropertyName = "SavedAmount", DefaultCellStyle = { Format = "N2" } });
            dataGridViewSavings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Прогрес (%)", DataPropertyName = "Progress", DefaultCellStyle = { Format = "F1" } });
            dataGridViewSavings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Внесок/міс (₴)", DataPropertyName = "MonthlyRequired", DefaultCellStyle = { Format = "N2" } });
            dataGridViewSavings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Дедлайн", DataPropertyName = "Deadline", DefaultCellStyle = { Format = "dd.MM.yyyy" } });
            dataGridViewSavings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Нотатка", DataPropertyName = "Note" });
        }

        private void InitializeBudgetGrid()
        {
            dataGridViewBudget.AutoGenerateColumns = false;
            dataGridViewBudget.EnableHeadersVisualStyles = false;
            dataGridViewBudget.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewBudget.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewBudget.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewBudget.ColumnHeadersHeight = 40;
            dataGridViewBudget.RowTemplate.Height = 32;

            dataGridViewBudget.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Категорія", DataPropertyName = "Category" });
            dataGridViewBudget.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ліміт (₴)", DataPropertyName = "LimitAmount", DefaultCellStyle = { Format = "N2" } });
            dataGridViewBudget.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Витрачено (₴)", DataPropertyName = "SpentAmount", DefaultCellStyle = { Format = "N2" } });
            dataGridViewBudget.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Залишок (₴)", DataPropertyName = "Remaining", DefaultCellStyle = { Format = "N2" } });
            dataGridViewBudget.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Перевищено", DataPropertyName = "IsExceeded" });
            dataGridViewBudget.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Можна/день (₴)", DataPropertyName = "DailyAllowance", DefaultCellStyle = { Format = "N2" } });
        }

        private void btnAddSavingsGoal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSavingsName.Text))
            { ShowError("Введіть назву цілі"); return; }

            if (!decimal.TryParse(textBoxSavingsTarget.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal target) || target <= 0)
            { ShowError("Введіть коректну суму цілі"); return; }

            SavingsGoalAddRequested.Invoke(this, new SavingsGoal
            {
                Name = textBoxSavingsName.Text.Trim(),
                TargetAmount = target,
                Deadline = dateTimePickerSavingsDeadline.Value,
                Note = string.IsNullOrWhiteSpace(textBoxSavingsNote.Text) ? null : textBoxSavingsNote.Text.Trim()
            });

            textBoxSavingsName.Clear();
            textBoxSavingsTarget.Clear();
            textBoxSavingsNote.Clear();
            dateTimePickerSavingsDeadline.Value = DateTime.Now.AddMonths(6);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSavings.SelectedRows.Count == 0)
            { ShowError("Виберіть ціль для поповнення"); return; }

            if (!decimal.TryParse(textBoxDepositAmount.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal amount) || amount <= 0)
            { ShowError("Введіть коректну суму"); return; }

            if (dataGridViewSavings.SelectedRows[0].DataBoundItem is SavingsGoal goal)
                SavingsDepositRequested.Invoke(this, (goal.Id, amount));

            textBoxDepositAmount.Clear();
        }

        private void btnDeleteSavingsGoal_Click(object sender, EventArgs e)
        {
            if (dataGridViewSavings.SelectedRows.Count == 0)
            { ShowError("Виберіть ціль для видалення"); return; }

            if (MessageBox.Show("Видалити обрану ціль?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                && dataGridViewSavings.SelectedRows[0].DataBoundItem is SavingsGoal goal)
                SavingsGoalDeleteRequested.Invoke(this, goal.Id);
        }

        private void btnAddBudgetLimit_Click(object sender, EventArgs e)
        {
            if (comboBoxBudgetCategory.SelectedIndex == -1)
            { ShowError("Виберіть категорію"); return; }

            if (!decimal.TryParse(textBoxBudgetLimit.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal limit) || limit <= 0)
            { ShowError("Введіть коректний ліміт"); return; }

            BudgetLimitAddRequested.Invoke(this, new BudgetLimit
            {
                Category = comboBoxBudgetCategory.SelectedItem?.ToString() ?? string.Empty,
                LimitAmount = limit,
                Month = DateTime.Now.Month,
                Year = DateTime.Now.Year
            });

            comboBoxBudgetCategory.SelectedIndex = -1;
            textBoxBudgetLimit.Clear();
        }

        private void btnDeleteBudgetLimit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBudget.SelectedRows.Count == 0)
            { ShowError("Виберіть ліміт для видалення"); return; }

            if (MessageBox.Show("Видалити обраний ліміт?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                && dataGridViewBudget.SelectedRows[0].DataBoundItem is BudgetLimit b)
                BudgetLimitDeleteRequested.Invoke(this, b.Id);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
            => ReportRequest.Invoke(this, "pdf");

        public void ShowCombinedChart(List<(string Label, decimal Income, decimal Expense, decimal Balance)> data,
                                        (string Label, decimal ForecastBalance) forecast)
        {
            chartLine.Series["Доходи"].Points.Clear();
            chartLine.Series["Витрати"].Points.Clear();
            chartLine.Series["Баланс"].Points.Clear();
            chartLine.Series["Прогноз"].Points.Clear();

            foreach (var (label, income, expense, balance) in data)
            {
                chartLine.Series["Доходи"].Points.AddXY(label, (double)income);
                chartLine.Series["Витрати"].Points.AddXY(label, (double)expense);
                chartLine.Series["Баланс"].Points.AddXY(label, (double)balance);
            }

            if (data.Count > 0)
            {
                var lastLabel = data[^1].Label;
                var lastBalance = (double)data[^1].Balance;

                chartLine.Series["Прогноз"].Points.AddXY(lastLabel, lastBalance);
                chartLine.Series["Прогноз"].Points.AddXY(forecast.Label, (double)forecast.ForecastBalance);
            }
        }
    }
}
