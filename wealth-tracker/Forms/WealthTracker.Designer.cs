using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace wealth_tracker
{
    partial class WealthTracker
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Tab Control ───────────────────────────────────────────
            tabControlMain = new TabControl();
            tabPageDashboard = new TabPage();
            tabPageTransactions = new TabPage();
            tabPageAnalytics = new TabPage();
            tabPageSavings = new TabPage();
            tabPageBudget = new TabPage();

            // ── Dashboard ─────────────────────────────────────────────
            panelStatistics = new Panel();
            labelBalance = new Label();
            labelTotalIncome = new Label();
            labelTotalExpenses = new Label();
            labelTransactionCount = new Label();
            labelForecast = new Label();
            pictureBoxWallet = new PictureBox();
            groupBoxAddTransaction = new GroupBox();
            labelType = new Label();
            radioButtonExpense = new RadioButton();
            radioButtonIncome = new RadioButton();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            labelAmount = new Label();
            textBoxAmount = new TextBox();
            labelDate = new Label();
            dateTimePickerTransaction = new DateTimePicker();
            btnAddTransaction = new Button();

            // ── Transactions ──────────────────────────────────────────
            panelFilter = new Panel();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            checkBoxFilterDate = new CheckBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            dataGridViewTransactions = new DataGridView();
            btnDeleteTransaction = new Button();
            btnExport = new Button();
            btnSaveXml = new Button();
            btnClearFilter = new Button();
            btnFilter = new Button();

            // ── Analytics ─────────────────────────────────────────────
            chartPie = new Chart();
            chartLine = new Chart();

            // ── Savings (Тумбочка) ────────────────────────────────────
            groupBoxAddSavings = new GroupBox();
            labelSavingsName = new Label();
            textBoxSavingsName = new TextBox();
            labelSavingsTarget = new Label();
            textBoxSavingsTarget = new TextBox();
            labelSavingsDeadline = new Label();
            dateTimePickerSavingsDeadline = new DateTimePicker();
            labelSavingsNote = new Label();
            textBoxSavingsNote = new TextBox();
            btnAddSavingsGoal = new Button();
            dataGridViewSavings = new DataGridView();
            groupBoxDeposit = new GroupBox();
            labelDepositAmount = new Label();
            textBoxDepositAmount = new TextBox();
            btnDeposit = new Button();
            btnDeleteSavingsGoal = new Button();

            // ── Budget ────────────────────────────────────────────────
            groupBoxAddBudget = new GroupBox();
            labelBudgetCategory = new Label();
            comboBoxBudgetCategory = new ComboBox();
            labelBudgetLimit = new Label();
            textBoxBudgetLimit = new TextBox();
            btnAddBudgetLimit = new Button();
            dataGridViewBudget = new DataGridView();
            btnDeleteBudgetLimit = new Button();
            btnGenerateReport = new Button();

            // ══════════════════════════════════════════════════════════
            tabControlMain.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            panelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWallet).BeginInit();
            groupBoxAddTransaction.SuspendLayout();
            tabPageTransactions.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            tabPageSavings.SuspendLayout();
            groupBoxAddSavings.SuspendLayout();
            groupBoxDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).BeginInit();
            tabPageBudget.SuspendLayout();
            groupBoxAddBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudget).BeginInit();
            SuspendLayout();

            // ── tabControlMain ────────────────────────────────────────
            tabControlMain.Controls.Add(tabPageDashboard);
            tabControlMain.Controls.Add(tabPageTransactions);
            tabControlMain.Controls.Add(tabPageAnalytics);
            tabControlMain.Controls.Add(tabPageSavings);
            tabControlMain.Controls.Add(tabPageBudget);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10F);
            tabControlMain.ItemSize = new Size(140, 36);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1100, 700);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;

            // ── tabPageDashboard ──────────────────────────────────────
            tabPageDashboard.Controls.Add(panelStatistics);
            tabPageDashboard.Controls.Add(pictureBoxWallet);
            tabPageDashboard.Controls.Add(groupBoxAddTransaction);
            tabPageDashboard.Location = new Point(4, 40);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(10);
            tabPageDashboard.Size = new Size(1092, 656);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Головна";

            // ── panelStatistics ───────────────────────────────────────
            panelStatistics.BackColor = Color.FromArgb(236, 240, 241);
            panelStatistics.Controls.Add(labelBalance);
            panelStatistics.Controls.Add(labelTotalIncome);
            panelStatistics.Controls.Add(labelTotalExpenses);
            panelStatistics.Controls.Add(labelTransactionCount);
            panelStatistics.Controls.Add(labelForecast);
            panelStatistics.Location = new Point(10, 13);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(1068, 137);
            panelStatistics.TabIndex = 0;

            // labelBalance
            labelBalance.BackColor = Color.White;
            labelBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelBalance.ForeColor = Color.FromArgb(44, 62, 80);
            labelBalance.Location = new Point(9, 10);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(200, 112);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Баланс\n0.00 ₴";
            labelBalance.TextAlign = ContentAlignment.MiddleCenter;

            // labelTotalIncome
            labelTotalIncome.BackColor = Color.White;
            labelTotalIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalIncome.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalIncome.Location = new Point(219, 10);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(200, 112);
            labelTotalIncome.TabIndex = 1;
            labelTotalIncome.Text = "Доходи\n0.00 ₴";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleCenter;

            // labelTotalExpenses
            labelTotalExpenses.BackColor = Color.White;
            labelTotalExpenses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalExpenses.ForeColor = Color.FromArgb(192, 57, 43);
            labelTotalExpenses.Location = new Point(429, 10);
            labelTotalExpenses.Name = "labelTotalExpenses";
            labelTotalExpenses.Size = new Size(200, 112);
            labelTotalExpenses.TabIndex = 2;
            labelTotalExpenses.Text = "Витрати\n0.00 ₴";
            labelTotalExpenses.TextAlign = ContentAlignment.MiddleCenter;

            // labelTransactionCount
            labelTransactionCount.BackColor = Color.White;
            labelTransactionCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTransactionCount.ForeColor = Color.FromArgb(44, 62, 80);
            labelTransactionCount.Location = new Point(639, 10);
            labelTransactionCount.Name = "labelTransactionCount";
            labelTransactionCount.Size = new Size(200, 112);
            labelTransactionCount.TabIndex = 3;
            labelTransactionCount.Text = "Транзакцій: 0";
            labelTransactionCount.TextAlign = ContentAlignment.MiddleCenter;

            // labelForecast — НОВИЙ
            labelForecast.BackColor = Color.FromArgb(214, 234, 248);
            labelForecast.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelForecast.ForeColor = Color.FromArgb(44, 62, 80);
            labelForecast.Location = new Point(849, 10);
            labelForecast.Name = "labelForecast";
            labelForecast.Size = new Size(210, 112);
            labelForecast.TabIndex = 4;
            labelForecast.Text = "Прогноз на кінець місяця\n0.00 ₴";
            labelForecast.TextAlign = ContentAlignment.MiddleCenter;

            // pictureBoxWallet
            pictureBoxWallet.BackColor = Color.White;
            pictureBoxWallet.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxWallet.Location = new Point(10, 157);
            pictureBoxWallet.Name = "pictureBoxWallet";
            pictureBoxWallet.Size = new Size(245, 230);
            pictureBoxWallet.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWallet.TabIndex = 1;
            pictureBoxWallet.TabStop = false;

            // groupBoxAddTransaction
            groupBoxAddTransaction.Controls.Add(labelType);
            groupBoxAddTransaction.Controls.Add(radioButtonExpense);
            groupBoxAddTransaction.Controls.Add(radioButtonIncome);
            groupBoxAddTransaction.Controls.Add(labelCategory);
            groupBoxAddTransaction.Controls.Add(comboBoxCategory);
            groupBoxAddTransaction.Controls.Add(labelAmount);
            groupBoxAddTransaction.Controls.Add(textBoxAmount);
            groupBoxAddTransaction.Controls.Add(labelDate);
            groupBoxAddTransaction.Controls.Add(dateTimePickerTransaction);
            groupBoxAddTransaction.Controls.Add(btnAddTransaction);
            groupBoxAddTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddTransaction.Location = new Point(268, 157);
            groupBoxAddTransaction.Name = "groupBoxAddTransaction";
            groupBoxAddTransaction.Size = new Size(800, 231);
            groupBoxAddTransaction.TabIndex = 2;
            groupBoxAddTransaction.TabStop = false;
            groupBoxAddTransaction.Text = "Додати транзакцію";

            // controls inside groupBoxAddTransaction
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F);
            labelType.Location = new Point(15, 30);
            labelType.Name = "labelType";
            labelType.Text = "Тип транзакції:";

            radioButtonExpense.AutoSize = true;
            radioButtonExpense.Checked = true;
            radioButtonExpense.Font = new Font("Segoe UI", 9F);
            radioButtonExpense.Location = new Point(15, 52);
            radioButtonExpense.Name = "radioButtonExpense";
            radioButtonExpense.Text = "Витрата";
            radioButtonExpense.CheckedChanged += radioButtonExpense_CheckedChanged;

            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Font = new Font("Segoe UI", 9F);
            radioButtonIncome.Location = new Point(140, 52);
            radioButtonIncome.Name = "radioButtonIncome";
            radioButtonIncome.Text = "Дохід";
            radioButtonIncome.CheckedChanged += radioButtonIncome_CheckedChanged;

            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 9F);
            labelCategory.Location = new Point(15, 85);
            labelCategory.Name = "labelCategory";
            labelCategory.Text = "Категорія:";

            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(15, 106);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(221, 25);

            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F);
            labelAmount.Location = new Point(251, 85);
            labelAmount.Name = "labelAmount";
            labelAmount.Text = "Сума (₴):";

            textBoxAmount.Font = new Font("Segoe UI", 10F);
            textBoxAmount.Location = new Point(251, 106);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(151, 25);

            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(418, 85);
            labelDate.Name = "labelDate";
            labelDate.Text = "Дата:";

            dateTimePickerTransaction.Font = new Font("Segoe UI", 10F);
            dateTimePickerTransaction.Format = DateTimePickerFormat.Short;
            dateTimePickerTransaction.Location = new Point(418, 106);
            dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            dateTimePickerTransaction.Size = new Size(151, 25);

            btnAddTransaction.BackColor = Color.FromArgb(46, 204, 113);
            btnAddTransaction.Cursor = Cursors.Hand;
            btnAddTransaction.FlatAppearance.BorderSize = 0;
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTransaction.ForeColor = Color.White;
            btnAddTransaction.Location = new Point(15, 167);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(768, 44);
            btnAddTransaction.Text = "Додати транзакцію";
            btnAddTransaction.UseVisualStyleBackColor = false;
            btnAddTransaction.Click += btnAddTransaction_Click;

            // ── tabPageTransactions ───────────────────────────────────
            tabPageTransactions.Controls.Add(panelFilter);
            tabPageTransactions.Controls.Add(dataGridViewTransactions);
            tabPageTransactions.Controls.Add(btnDeleteTransaction);
            tabPageTransactions.Controls.Add(btnExport);
            tabPageTransactions.Controls.Add(btnSaveXml);
            tabPageTransactions.Controls.Add(btnClearFilter);
            tabPageTransactions.Controls.Add(btnFilter);
            tabPageTransactions.Location = new Point(4, 40);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Padding = new Padding(10);
            tabPageTransactions.Size = new Size(1092, 656);
            tabPageTransactions.TabIndex = 1;
            tabPageTransactions.Text = "Транзакції";

            panelFilter.BackColor = Color.FromArgb(245, 245, 245);
            panelFilter.Controls.Add(labelSearch);
            panelFilter.Controls.Add(textBoxSearch);
            panelFilter.Controls.Add(checkBoxFilterDate);
            panelFilter.Controls.Add(dateTimePickerStart);
            panelFilter.Controls.Add(dateTimePickerEnd);
            panelFilter.Location = new Point(10, 10);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1068, 55);

            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(1020, 14);
            labelSearch.Name = "labelSearch";
            labelSearch.Click += labelSearch_Click;

            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(830, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(180, 25);
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;

            checkBoxFilterDate.AutoSize = true;
            checkBoxFilterDate.Font = new Font("Segoe UI", 9F);
            checkBoxFilterDate.Location = new Point(14, 16);
            checkBoxFilterDate.Name = "checkBoxFilterDate";
            checkBoxFilterDate.Text = "За датою:";

            dateTimePickerStart.Font = new Font("Segoe UI", 9F);
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(117, 14);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(116, 23);

            dateTimePickerEnd.Font = new Font("Segoe UI", 9F);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(245, 14);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(116, 23);

            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.Location = new Point(10, 77);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.Size = new Size(1068, 460);
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.TabIndex = 1;

            btnDeleteTransaction.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteTransaction.Cursor = Cursors.Hand;
            btnDeleteTransaction.FlatAppearance.BorderSize = 0;
            btnDeleteTransaction.FlatStyle = FlatStyle.Flat;
            btnDeleteTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteTransaction.ForeColor = Color.White;
            btnDeleteTransaction.Location = new Point(880, 550);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(197, 59);
            btnDeleteTransaction.Text = "Видалити обране";
            btnDeleteTransaction.UseVisualStyleBackColor = false;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;

            btnExport.Location = new Point(337, 550);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(152, 59);
            btnExport.Text = "Експорт (.csv)";
            btnExport.Click += btnExport_Click;

            btnSaveXml.Location = new Point(498, 550);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(152, 59);
            btnSaveXml.Text = "Зберегти (.xml)";
            btnSaveXml.Click += btnSaveXml_Click;

            btnClearFilter.Location = new Point(170, 550);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(152, 59);
            btnClearFilter.Text = "Очистити фільтр";
            btnClearFilter.Click += btnClearFilter_Click;

            btnFilter.Location = new Point(9, 550);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(152, 59);
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;

            // ── tabPageAnalytics ──────────────────────────────────────
            tabPageAnalytics.Controls.Add(chartPie);
            tabPageAnalytics.Controls.Add(chartLine);
            tabPageAnalytics.Location = new Point(4, 40);
            tabPageAnalytics.Name = "tabPageAnalytics";
            tabPageAnalytics.Padding = new Padding(10);
            tabPageAnalytics.Size = new Size(1092, 656);
            tabPageAnalytics.TabIndex = 2;
            tabPageAnalytics.Text = "Аналітика";

            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            chartPie.Location = new Point(10, 10);
            chartPie.Name = "chartPie";
            chartPie.Size = new Size(650, 630);
            chartPie.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();

            ((System.ComponentModel.ISupportInitialize)chartLine).BeginInit();
            chartLine.Location = new Point(670, 10);
            chartLine.Name = "chartLine";
            chartLine.Size = new Size(410, 630);
            chartLine.TabIndex = 1;
            ((System.ComponentModel.ISupportInitialize)chartLine).EndInit();

            // ── tabPageSavings (Тумбочка) ─────────────────────────────
            tabPageSavings.Controls.Add(groupBoxAddSavings);
            tabPageSavings.Controls.Add(dataGridViewSavings);
            tabPageSavings.Controls.Add(groupBoxDeposit);
            tabPageSavings.Controls.Add(btnDeleteSavingsGoal);
            tabPageSavings.Location = new Point(4, 40);
            tabPageSavings.Name = "tabPageSavings";
            tabPageSavings.Padding = new Padding(10);
            tabPageSavings.Size = new Size(1092, 656);
            tabPageSavings.TabIndex = 3;
            tabPageSavings.Text = "Тумбочка";

            // groupBoxAddSavings
            groupBoxAddSavings.Controls.Add(labelSavingsName);
            groupBoxAddSavings.Controls.Add(textBoxSavingsName);
            groupBoxAddSavings.Controls.Add(labelSavingsTarget);
            groupBoxAddSavings.Controls.Add(textBoxSavingsTarget);
            groupBoxAddSavings.Controls.Add(labelSavingsDeadline);
            groupBoxAddSavings.Controls.Add(dateTimePickerSavingsDeadline);
            groupBoxAddSavings.Controls.Add(labelSavingsNote);
            groupBoxAddSavings.Controls.Add(textBoxSavingsNote);
            groupBoxAddSavings.Controls.Add(btnAddSavingsGoal);
            groupBoxAddSavings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddSavings.Location = new Point(10, 10);
            groupBoxAddSavings.Name = "groupBoxAddSavings";
            groupBoxAddSavings.Size = new Size(1068, 160);
            groupBoxAddSavings.Text = "Нова ціль заощадження";

            labelSavingsName.AutoSize = true;
            labelSavingsName.Font = new Font("Segoe UI", 9F);
            labelSavingsName.Location = new Point(15, 30);
            labelSavingsName.Text = "Назва:";

            textBoxSavingsName.Font = new Font("Segoe UI", 10F);
            textBoxSavingsName.Location = new Point(15, 50);
            textBoxSavingsName.Name = "textBoxSavingsName";
            textBoxSavingsName.Size = new Size(220, 25);

            labelSavingsTarget.AutoSize = true;
            labelSavingsTarget.Font = new Font("Segoe UI", 9F);
            labelSavingsTarget.Location = new Point(250, 30);
            labelSavingsTarget.Text = "Сума цілі (₴):";

            textBoxSavingsTarget.Font = new Font("Segoe UI", 10F);
            textBoxSavingsTarget.Location = new Point(250, 50);
            textBoxSavingsTarget.Name = "textBoxSavingsTarget";
            textBoxSavingsTarget.Size = new Size(160, 25);

            labelSavingsDeadline.AutoSize = true;
            labelSavingsDeadline.Font = new Font("Segoe UI", 9F);
            labelSavingsDeadline.Location = new Point(425, 30);
            labelSavingsDeadline.Text = "Дедлайн:";

            dateTimePickerSavingsDeadline.Font = new Font("Segoe UI", 10F);
            dateTimePickerSavingsDeadline.Format = DateTimePickerFormat.Short;
            dateTimePickerSavingsDeadline.Location = new Point(425, 50);
            dateTimePickerSavingsDeadline.Name = "dateTimePickerSavingsDeadline";
            dateTimePickerSavingsDeadline.Size = new Size(160, 25);
            dateTimePickerSavingsDeadline.Value = DateTime.Now.AddMonths(6);

            labelSavingsNote.AutoSize = true;
            labelSavingsNote.Font = new Font("Segoe UI", 9F);
            labelSavingsNote.Location = new Point(600, 30);
            labelSavingsNote.Text = "Нотатка (необов'язково):";

            textBoxSavingsNote.Font = new Font("Segoe UI", 10F);
            textBoxSavingsNote.Location = new Point(600, 50);
            textBoxSavingsNote.Name = "textBoxSavingsNote";
            textBoxSavingsNote.Size = new Size(280, 25);

            btnAddSavingsGoal.BackColor = Color.FromArgb(52, 152, 219);
            btnAddSavingsGoal.Cursor = Cursors.Hand;
            btnAddSavingsGoal.FlatAppearance.BorderSize = 0;
            btnAddSavingsGoal.FlatStyle = FlatStyle.Flat;
            btnAddSavingsGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddSavingsGoal.ForeColor = Color.White;
            btnAddSavingsGoal.Location = new Point(15, 100);
            btnAddSavingsGoal.Name = "btnAddSavingsGoal";
            btnAddSavingsGoal.Size = new Size(1038, 44);
            btnAddSavingsGoal.Text = "Додати ціль";
            btnAddSavingsGoal.UseVisualStyleBackColor = false;
            btnAddSavingsGoal.Click += btnAddSavingsGoal_Click;

            // dataGridViewSavings
            dataGridViewSavings.BackgroundColor = Color.White;
            dataGridViewSavings.BorderStyle = BorderStyle.None;
            dataGridViewSavings.Location = new Point(10, 180);
            dataGridViewSavings.Name = "dataGridViewSavings";
            dataGridViewSavings.Size = new Size(1068, 350);
            dataGridViewSavings.TabIndex = 1;
            dataGridViewSavings.ReadOnly = true;
            dataGridViewSavings.AllowUserToAddRows = false;
            dataGridViewSavings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSavings.RowHeadersVisible = false;
            dataGridViewSavings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // groupBoxDeposit
            groupBoxDeposit.Controls.Add(labelDepositAmount);
            groupBoxDeposit.Controls.Add(textBoxDepositAmount);
            groupBoxDeposit.Controls.Add(btnDeposit);
            groupBoxDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDeposit.Location = new Point(10, 540);
            groupBoxDeposit.Name = "groupBoxDeposit";
            groupBoxDeposit.Size = new Size(500, 80);
            groupBoxDeposit.Text = "Поповнити обрану ціль";

            labelDepositAmount.AutoSize = true;
            labelDepositAmount.Font = new Font("Segoe UI", 9F);
            labelDepositAmount.Location = new Point(15, 28);
            labelDepositAmount.Text = "Сума (₴):";

            textBoxDepositAmount.Font = new Font("Segoe UI", 10F);
            textBoxDepositAmount.Location = new Point(15, 46);
            textBoxDepositAmount.Name = "textBoxDepositAmount";
            textBoxDepositAmount.Size = new Size(160, 25);

            btnDeposit.BackColor = Color.FromArgb(46, 204, 113);
            btnDeposit.Cursor = Cursors.Hand;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(190, 43);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(290, 30);
            btnDeposit.Text = "Відкласти в тумбочку";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;

            btnDeleteSavingsGoal.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteSavingsGoal.Cursor = Cursors.Hand;
            btnDeleteSavingsGoal.FlatAppearance.BorderSize = 0;
            btnDeleteSavingsGoal.FlatStyle = FlatStyle.Flat;
            btnDeleteSavingsGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteSavingsGoal.ForeColor = Color.White;
            btnDeleteSavingsGoal.Location = new Point(880, 545);
            btnDeleteSavingsGoal.Name = "btnDeleteSavingsGoal";
            btnDeleteSavingsGoal.Size = new Size(197, 59);
            btnDeleteSavingsGoal.Text = "Видалити ціль";
            btnDeleteSavingsGoal.UseVisualStyleBackColor = false;
            btnDeleteSavingsGoal.Click += btnDeleteSavingsGoal_Click;

            // ── tabPageBudget ─────────────────────────────────────────
            tabPageBudget.Controls.Add(groupBoxAddBudget);
            tabPageBudget.Controls.Add(dataGridViewBudget);
            tabPageBudget.Controls.Add(btnDeleteBudgetLimit);
            tabPageBudget.Controls.Add(btnGenerateReport);
            tabPageBudget.Location = new Point(4, 40);
            tabPageBudget.Name = "tabPageBudget";
            tabPageBudget.Padding = new Padding(10);
            tabPageBudget.Size = new Size(1092, 656);
            tabPageBudget.TabIndex = 4;
            tabPageBudget.Text = "Бюджет";

            // groupBoxAddBudget
            groupBoxAddBudget.Controls.Add(labelBudgetCategory);
            groupBoxAddBudget.Controls.Add(comboBoxBudgetCategory);
            groupBoxAddBudget.Controls.Add(labelBudgetLimit);
            groupBoxAddBudget.Controls.Add(textBoxBudgetLimit);
            groupBoxAddBudget.Controls.Add(btnAddBudgetLimit);
            groupBoxAddBudget.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddBudget.Location = new Point(10, 10);
            groupBoxAddBudget.Name = "groupBoxAddBudget";
            groupBoxAddBudget.Size = new Size(1068, 120);
            groupBoxAddBudget.Text = "Встановити місячний ліміт";

            labelBudgetCategory.AutoSize = true;
            labelBudgetCategory.Font = new Font("Segoe UI", 9F);
            labelBudgetCategory.Location = new Point(15, 30);
            labelBudgetCategory.Text = "Категорія:";

            comboBoxBudgetCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBudgetCategory.Font = new Font("Segoe UI", 10F);
            comboBoxBudgetCategory.Location = new Point(15, 50);
            comboBoxBudgetCategory.Name = "comboBoxBudgetCategory";
            comboBoxBudgetCategory.Size = new Size(221, 25);

            labelBudgetLimit.AutoSize = true;
            labelBudgetLimit.Font = new Font("Segoe UI", 9F);
            labelBudgetLimit.Location = new Point(250, 30);
            labelBudgetLimit.Text = "Ліміт на місяць (₴):";

            textBoxBudgetLimit.Font = new Font("Segoe UI", 10F);
            textBoxBudgetLimit.Location = new Point(250, 50);
            textBoxBudgetLimit.Name = "textBoxBudgetLimit";
            textBoxBudgetLimit.Size = new Size(160, 25);

            btnAddBudgetLimit.BackColor = Color.FromArgb(155, 89, 182);
            btnAddBudgetLimit.Cursor = Cursors.Hand;
            btnAddBudgetLimit.FlatAppearance.BorderSize = 0;
            btnAddBudgetLimit.FlatStyle = FlatStyle.Flat;
            btnAddBudgetLimit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBudgetLimit.ForeColor = Color.White;
            btnAddBudgetLimit.Location = new Point(430, 46);
            btnAddBudgetLimit.Name = "btnAddBudgetLimit";
            btnAddBudgetLimit.Size = new Size(623, 32);
            btnAddBudgetLimit.Text = "Встановити ліміт";
            btnAddBudgetLimit.UseVisualStyleBackColor = false;
            btnAddBudgetLimit.Click += btnAddBudgetLimit_Click;

            // dataGridViewBudget
            dataGridViewBudget.BackgroundColor = Color.White;
            dataGridViewBudget.BorderStyle = BorderStyle.None;
            dataGridViewBudget.Location = new Point(10, 140);
            dataGridViewBudget.Name = "dataGridViewBudget";
            dataGridViewBudget.Size = new Size(1068, 390);
            dataGridViewBudget.TabIndex = 1;
            dataGridViewBudget.ReadOnly = true;
            dataGridViewBudget.AllowUserToAddRows = false;
            dataGridViewBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudget.RowHeadersVisible = false;
            dataGridViewBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnDeleteBudgetLimit.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteBudgetLimit.Cursor = Cursors.Hand;
            btnDeleteBudgetLimit.FlatAppearance.BorderSize = 0;
            btnDeleteBudgetLimit.FlatStyle = FlatStyle.Flat;
            btnDeleteBudgetLimit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBudgetLimit.ForeColor = Color.White;
            btnDeleteBudgetLimit.Location = new Point(880, 545);
            btnDeleteBudgetLimit.Name = "btnDeleteBudgetLimit";
            btnDeleteBudgetLimit.Size = new Size(197, 59);
            btnDeleteBudgetLimit.Text = "Видалити ліміт";
            btnDeleteBudgetLimit.UseVisualStyleBackColor = false;
            btnDeleteBudgetLimit.Click += btnDeleteBudgetLimit_Click;

            btnGenerateReport.BackColor = Color.FromArgb(41, 128, 185);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(10, 545);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(300, 59);
            btnGenerateReport.Text = "Згенерувати PDF звіт";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(tabControlMain);
            MinimumSize = new Size(1116, 739);
            Name = "WealthTracker";
            Text = "WealthTracker";
            Load += WealthTracker_Load;

            tabControlMain.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            panelStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWallet).EndInit();
            groupBoxAddTransaction.ResumeLayout(false);
            groupBoxAddTransaction.PerformLayout();
            tabPageTransactions.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            tabPageSavings.ResumeLayout(false);
            groupBoxAddSavings.ResumeLayout(false);
            groupBoxAddSavings.PerformLayout();
            groupBoxDeposit.ResumeLayout(false);
            groupBoxDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).EndInit();
            tabPageBudget.ResumeLayout(false);
            groupBoxAddBudget.ResumeLayout(false);
            groupBoxAddBudget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudget).EndInit();
            ResumeLayout(false);
        }

        private TabControl tabControlMain;
        private TabPage tabPageDashboard;
        private TabPage tabPageTransactions;
        private TabPage tabPageAnalytics;
        private Panel panelStatistics;
        private Label labelBalance;
        private Label labelTotalIncome;
        private Label labelTotalExpenses;
        private Label labelTransactionCount;
        private Label labelForecast;
        private PictureBox pictureBoxWallet;
        private GroupBox groupBoxAddTransaction;
        private Label labelType;
        private RadioButton radioButtonExpense;
        private RadioButton radioButtonIncome;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Label labelAmount;
        private TextBox textBoxAmount;
        private Label labelDate;
        private DateTimePicker dateTimePickerTransaction;
        private Button btnAddTransaction;
        private Panel panelFilter;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private CheckBox checkBoxFilterDate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button btnFilter;
        private Button btnClearFilter;
        private Button btnExport;
        private Button btnSaveXml;
        private DataGridView dataGridViewTransactions;
        private Button btnDeleteTransaction;
        private Chart chartPie;
        private Chart chartLine;

        private TabPage tabPageSavings;
        private GroupBox groupBoxAddSavings;
        private Label labelSavingsName;
        private TextBox textBoxSavingsName;
        private Label labelSavingsTarget;
        private TextBox textBoxSavingsTarget;
        private Label labelSavingsDeadline;
        private DateTimePicker dateTimePickerSavingsDeadline;
        private Label labelSavingsNote;
        private TextBox textBoxSavingsNote;
        private Button btnAddSavingsGoal;
        private DataGridView dataGridViewSavings;
        private GroupBox groupBoxDeposit;
        private Label labelDepositAmount;
        private TextBox textBoxDepositAmount;
        private Button btnDeposit;
        private Button btnDeleteSavingsGoal;

        private TabPage tabPageBudget;
        private GroupBox groupBoxAddBudget;
        private Label labelBudgetCategory;
        private ComboBox comboBoxBudgetCategory;
        private Label labelBudgetLimit;
        private TextBox textBoxBudgetLimit;
        private Button btnAddBudgetLimit;
        private DataGridView dataGridViewBudget;
        private Button btnDeleteBudgetLimit;
        private Button btnGenerateReport;
    }
}