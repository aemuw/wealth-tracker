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
            tabControlMain = new TabControl();
            tabPageDashboard = new TabPage();
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
            labelNote = new Label();
            textBoxNote = new TextBox();
            checkBoxRecurring = new CheckBox();
            labelRecurringDay = new Label();
            numericRecurringDay = new NumericUpDown();
            btnAddTransaction = new Button();
            tabPageTransactions = new TabPage();
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
            tabPageAnalytics = new TabPage();
            chartPie = new Chart();
            chartLine = new Chart();
            tabPageSavings = new TabPage();
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
            chartSavings = new Chart();
            groupBoxDeposit = new GroupBox();
            labelDepositAmount = new Label();
            textBoxDepositAmount = new TextBox();
            btnDeposit = new Button();
            groupBoxTransfer = new GroupBox();
            labelTransferTo = new Label();
            comboBoxTransferTo = new ComboBox();
            labelTransferAmount = new Label();
            textBoxTransferAmount = new TextBox();
            btnTransfer = new Button();
            groupBox1 = new GroupBox();
            btnDeleteSavingsGoal = new Button();
            tabPageBudget = new TabPage();
            groupBoxAddBudget = new GroupBox();
            labelBudgetCategory = new Label();
            comboBoxBudgetCategory = new ComboBox();
            labelBudgetLimit = new Label();
            textBoxBudgetLimit = new TextBox();
            btnAddBudgetLimit = new Button();
            dataGridViewBudget = new DataGridView();
            btnDeleteBudgetLimit = new Button();
            btnGenerateReport = new Button();

            tabControlMain.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            panelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWallet).BeginInit();
            groupBoxAddTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRecurringDay).BeginInit();
            tabPageTransactions.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            tabPageAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartLine).BeginInit();
            tabPageSavings.SuspendLayout();
            groupBoxAddSavings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartSavings).BeginInit();
            groupBoxDeposit.SuspendLayout();
            groupBoxTransfer.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageBudget.SuspendLayout();
            groupBoxAddBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudget).BeginInit();
            SuspendLayout();

            // ── tabControlMain ──────────────────────────────────────────
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
            tabControlMain.Size = new Size(1100, 720);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;

            // ── tabPageDashboard ────────────────────────────────────────
            // Tab inner size: 1092 × 676
            tabPageDashboard.Controls.Add(panelStatistics);
            tabPageDashboard.Controls.Add(pictureBoxWallet);
            tabPageDashboard.Controls.Add(groupBoxAddTransaction);
            tabPageDashboard.Location = new Point(4, 40);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(10);
            tabPageDashboard.Size = new Size(1092, 676);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Головна";

            // panelStatistics  h=100
            panelStatistics.BackColor = Color.FromArgb(236, 240, 241);
            panelStatistics.Controls.Add(labelBalance);
            panelStatistics.Controls.Add(labelTotalIncome);
            panelStatistics.Controls.Add(labelTotalExpenses);
            panelStatistics.Controls.Add(labelTransactionCount);
            panelStatistics.Controls.Add(labelForecast);
            panelStatistics.Location = new Point(10, 10);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(1072, 100);

            int statW = 200, statH = 80, statY = 10;
            labelBalance.BackColor = Color.White;
            labelBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelBalance.ForeColor = Color.FromArgb(44, 62, 80);
            labelBalance.Location = new Point(6, statY);
            labelBalance.Size = new Size(statW, statH);
            labelBalance.Text = "Баланс\n0.00 ₴";
            labelBalance.TextAlign = ContentAlignment.MiddleCenter;

            labelTotalIncome.BackColor = Color.White;
            labelTotalIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalIncome.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalIncome.Location = new Point(214, statY);
            labelTotalIncome.Size = new Size(statW, statH);
            labelTotalIncome.Text = "Доходи\n0.00 ₴";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleCenter;

            labelTotalExpenses.BackColor = Color.White;
            labelTotalExpenses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalExpenses.ForeColor = Color.FromArgb(192, 57, 43);
            labelTotalExpenses.Location = new Point(422, statY);
            labelTotalExpenses.Size = new Size(statW, statH);
            labelTotalExpenses.Text = "Витрати\n0.00 ₴";
            labelTotalExpenses.TextAlign = ContentAlignment.MiddleCenter;

            labelTransactionCount.BackColor = Color.White;
            labelTransactionCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTransactionCount.ForeColor = Color.FromArgb(44, 62, 80);
            labelTransactionCount.Location = new Point(630, statY);
            labelTransactionCount.Size = new Size(statW, statH);
            labelTransactionCount.Text = "Транзакцій: 0";
            labelTransactionCount.TextAlign = ContentAlignment.MiddleCenter;

            labelForecast.BackColor = Color.FromArgb(214, 234, 248);
            labelForecast.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelForecast.ForeColor = Color.FromArgb(44, 62, 80);
            labelForecast.Location = new Point(838, statY);
            labelForecast.Size = new Size(228, statH);
            labelForecast.Text = "Прогноз на кінець місяця\n0.00 ₴";
            labelForecast.TextAlign = ContentAlignment.MiddleCenter;

            // pictureBoxWallet  y=120  h=260  => bottom=380 < 676 ok
            pictureBoxWallet.BackColor = Color.White;
            pictureBoxWallet.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxWallet.Location = new Point(10, 120);
            pictureBoxWallet.Name = "pictureBoxWallet";
            pictureBoxWallet.Size = new Size(250, 260);
            pictureBoxWallet.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWallet.TabStop = false;

            // groupBoxAddTransaction  y=120  h=270 => bottom=390
            groupBoxAddTransaction.Controls.Add(labelType);
            groupBoxAddTransaction.Controls.Add(radioButtonExpense);
            groupBoxAddTransaction.Controls.Add(radioButtonIncome);
            groupBoxAddTransaction.Controls.Add(labelCategory);
            groupBoxAddTransaction.Controls.Add(comboBoxCategory);
            groupBoxAddTransaction.Controls.Add(labelAmount);
            groupBoxAddTransaction.Controls.Add(textBoxAmount);
            groupBoxAddTransaction.Controls.Add(labelDate);
            groupBoxAddTransaction.Controls.Add(dateTimePickerTransaction);
            groupBoxAddTransaction.Controls.Add(labelNote);
            groupBoxAddTransaction.Controls.Add(textBoxNote);
            groupBoxAddTransaction.Controls.Add(checkBoxRecurring);
            groupBoxAddTransaction.Controls.Add(labelRecurringDay);
            groupBoxAddTransaction.Controls.Add(numericRecurringDay);
            groupBoxAddTransaction.Controls.Add(btnAddTransaction);
            groupBoxAddTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddTransaction.Location = new Point(270, 120);
            groupBoxAddTransaction.Name = "groupBoxAddTransaction";
            groupBoxAddTransaction.Size = new Size(812, 270);
            groupBoxAddTransaction.TabStop = false;
            groupBoxAddTransaction.Text = "Додати транзакцію";

            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F);
            labelType.Location = new Point(14, 28);
            labelType.Text = "Тип транзакції:";

            radioButtonExpense.AutoSize = true;
            radioButtonExpense.Checked = true;
            radioButtonExpense.Font = new Font("Segoe UI", 9F);
            radioButtonExpense.Location = new Point(14, 52);
            radioButtonExpense.TabStop = true;
            radioButtonExpense.Text = "Витрата";
            radioButtonExpense.CheckedChanged += radioButtonExpense_CheckedChanged;

            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Font = new Font("Segoe UI", 9F);
            radioButtonIncome.Location = new Point(130, 52);
            radioButtonIncome.Text = "Дохід";
            radioButtonIncome.CheckedChanged += radioButtonIncome_CheckedChanged;

            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 9F);
            labelCategory.Location = new Point(14, 90);
            labelCategory.Text = "Категорія:";

            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(14, 112);
            comboBoxCategory.Size = new Size(210, 31);

            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F);
            labelAmount.Location = new Point(14, 158);
            labelAmount.Text = "Сума (₴):";

            textBoxAmount.Font = new Font("Segoe UI", 10F);
            textBoxAmount.Location = new Point(14, 180);
            textBoxAmount.Size = new Size(210, 30);

            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(242, 28);
            labelDate.Text = "Дата:";

            dateTimePickerTransaction.Font = new Font("Segoe UI", 10F);
            dateTimePickerTransaction.Format = DateTimePickerFormat.Short;
            dateTimePickerTransaction.Location = new Point(242, 52);
            dateTimePickerTransaction.Size = new Size(170, 30);

            labelNote.AutoSize = true;
            labelNote.Font = new Font("Segoe UI", 9F);
            labelNote.Location = new Point(430, 20);
            labelNote.Text = "Нотатка:";

            textBoxNote.Font = new Font("Segoe UI", 10F);
            textBoxNote.Location = new Point(430, 42);
            textBoxNote.Multiline = true;
            textBoxNote.Size = new Size(368, 175);

            checkBoxRecurring.AutoSize = true;
            checkBoxRecurring.Font = new Font("Segoe UI", 9F);
            checkBoxRecurring.Location = new Point(242, 180);
            checkBoxRecurring.Text = "Повторювана";
            checkBoxRecurring.CheckedChanged += checkBoxRecurring_CheckedChanged;

            labelRecurringDay.AutoSize = true;
            labelRecurringDay.Font = new Font("Segoe UI", 9F);
            labelRecurringDay.Location = new Point(242, 90);
            labelRecurringDay.Text = "День місяця:";
            labelRecurringDay.Visible = false;

            numericRecurringDay.Font = new Font("Segoe UI", 10F);
            numericRecurringDay.Location = new Point(242, 112);
            numericRecurringDay.Maximum = 28;
            numericRecurringDay.Minimum = 1;
            numericRecurringDay.Size = new Size(170, 30);
            numericRecurringDay.Value = 1;
            numericRecurringDay.Visible = false;

            btnAddTransaction.BackColor = Color.FromArgb(46, 204, 113);
            btnAddTransaction.Cursor = Cursors.Hand;
            btnAddTransaction.FlatAppearance.BorderSize = 0;
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTransaction.ForeColor = Color.White;
            btnAddTransaction.Location = new Point(14, 224);
            btnAddTransaction.Size = new Size(784, 36);
            btnAddTransaction.Text = "Додати транзакцію";
            btnAddTransaction.UseVisualStyleBackColor = false;
            btnAddTransaction.Click += btnAddTransaction_Click;

            // ── tabPageTransactions ──────────────────────────────────────
            // Layout: panelFilter(h=50) y=10 → grid y=68 h=536 → buttons y=612 h=50 → bottom=662 < 676 ✓
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
            tabPageTransactions.Size = new Size(1092, 676);
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
            panelFilter.Size = new Size(1072, 50);

            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(870, 14);
            labelSearch.Text = "Пошук:";
            labelSearch.Click += labelSearch_Click;

            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(930, 11);
            textBoxSearch.Size = new Size(138, 30);
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;

            checkBoxFilterDate.AutoSize = true;
            checkBoxFilterDate.Font = new Font("Segoe UI", 9F);
            checkBoxFilterDate.Location = new Point(10, 14);
            checkBoxFilterDate.Text = "За датою:";

            dateTimePickerStart.Font = new Font("Segoe UI", 9F);
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(115, 13);
            dateTimePickerStart.Size = new Size(130, 27);

            dateTimePickerEnd.Font = new Font("Segoe UI", 9F);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(255, 13);
            dateTimePickerEnd.Size = new Size(130, 27);

            // grid: y=68, h=536, bottom=604
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.ColumnHeadersHeight = 29;
            dataGridViewTransactions.Location = new Point(10, 68);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(1072, 534);

            // buttons: y=610, h=48, bottom=658 < 676 ✓
            int btnY = 610, btnH = 48, btnW = 170;
            btnFilter.Location = new Point(10, btnY);
            btnFilter.Size = new Size(btnW, btnH);
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;

            btnClearFilter.Location = new Point(188, btnY);
            btnClearFilter.Size = new Size(btnW, btnH);
            btnClearFilter.Text = "Очистити фільтр";
            btnClearFilter.Click += btnClearFilter_Click;

            btnExport.Location = new Point(366, btnY);
            btnExport.Size = new Size(btnW, btnH);
            btnExport.Text = "Експорт (.csv)";
            btnExport.Click += btnExport_Click;

            btnSaveXml.Location = new Point(544, btnY);
            btnSaveXml.Size = new Size(btnW, btnH);
            btnSaveXml.Text = "Зберегти (.xml)";
            btnSaveXml.Click += btnSaveXml_Click;

            btnDeleteTransaction.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteTransaction.Cursor = Cursors.Hand;
            btnDeleteTransaction.FlatAppearance.BorderSize = 0;
            btnDeleteTransaction.FlatStyle = FlatStyle.Flat;
            btnDeleteTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteTransaction.ForeColor = Color.White;
            btnDeleteTransaction.Location = new Point(912, btnY);
            btnDeleteTransaction.Size = new Size(170, btnH);
            btnDeleteTransaction.Text = "Видалити обране";
            btnDeleteTransaction.UseVisualStyleBackColor = false;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;

            // ── tabPageAnalytics ────────────────────────────────────────
            // chartPie left half, chartLine right half, full height
            tabPageAnalytics.Controls.Add(chartPie);
            tabPageAnalytics.Controls.Add(chartLine);
            tabPageAnalytics.Location = new Point(4, 40);
            tabPageAnalytics.Name = "tabPageAnalytics";
            tabPageAnalytics.Padding = new Padding(10);
            tabPageAnalytics.Size = new Size(1092, 676);
            tabPageAnalytics.TabIndex = 2;
            tabPageAnalytics.Text = "Аналітика";

            chartPie.Location = new Point(10, 10);
            chartPie.Name = "chartPie";
            chartPie.Size = new Size(530, 650);
            chartPie.TabStop = false;

            chartLine.Location = new Point(550, 10);
            chartLine.Name = "chartLine";
            chartLine.Size = new Size(532, 650);
            chartLine.TabStop = false;

            // ── tabPageSavings ──────────────────────────────────────────
            // Layout:
            //   groupBoxAddSavings  y=10   h=110  bottom=120
            //   dataGridViewSavings y=136  h=280  bottom=416
            //   chartSavings        y=420  h=120  bottom=540
            //   action row          y=546  h=120  bottom=666 < 676 ✓
            tabPageSavings.Controls.Add(groupBoxAddSavings);
            tabPageSavings.Controls.Add(dataGridViewSavings);
            tabPageSavings.Controls.Add(chartSavings);
            tabPageSavings.Controls.Add(groupBoxDeposit);
            tabPageSavings.Controls.Add(groupBox1);
            tabPageSavings.Controls.Add(groupBoxTransfer);
            tabPageSavings.Location = new Point(4, 40);
            tabPageSavings.Name = "tabPageSavings";
            tabPageSavings.Padding = new Padding(10);
            tabPageSavings.Size = new Size(1092, 676);
            tabPageSavings.TabIndex = 3;
            tabPageSavings.Text = "Тумбочка";

            // groupBoxAddSavings — horizontal one-line form
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
            groupBoxAddSavings.Size = new Size(1072, 118);
            groupBoxAddSavings.TabStop = false;
            groupBoxAddSavings.Text = "Нова ціль заощадження";

            labelSavingsName.AutoSize = true;
            labelSavingsName.Font = new Font("Segoe UI", 9F);
            labelSavingsName.Location = new Point(14, 30);
            labelSavingsName.Text = "Назва:";

            textBoxSavingsName.Font = new Font("Segoe UI", 10F);
            textBoxSavingsName.Location = new Point(14, 52);
            textBoxSavingsName.Size = new Size(196, 30);

            labelSavingsTarget.AutoSize = true;
            labelSavingsTarget.Font = new Font("Segoe UI", 9F);
            labelSavingsTarget.Location = new Point(220, 30);
            labelSavingsTarget.Text = "Сума (₴):";

            textBoxSavingsTarget.Font = new Font("Segoe UI", 10F);
            textBoxSavingsTarget.Location = new Point(220, 52);
            textBoxSavingsTarget.Size = new Size(148, 30);

            labelSavingsDeadline.AutoSize = true;
            labelSavingsDeadline.Font = new Font("Segoe UI", 9F);
            labelSavingsDeadline.Location = new Point(378, 30);
            labelSavingsDeadline.Text = "Дедлайн:";

            dateTimePickerSavingsDeadline.Font = new Font("Segoe UI", 10F);
            dateTimePickerSavingsDeadline.Format = DateTimePickerFormat.Short;
            dateTimePickerSavingsDeadline.Location = new Point(378, 52);
            dateTimePickerSavingsDeadline.MinDate = DateTime.Now.AddDays(2);
            dateTimePickerSavingsDeadline.Size = new Size(148, 30);
            dateTimePickerSavingsDeadline.Value = DateTime.Now.AddMonths(6);

            labelSavingsNote.AutoSize = true;
            labelSavingsNote.Font = new Font("Segoe UI", 9F);
            labelSavingsNote.Location = new Point(536, 30);
            labelSavingsNote.Text = "Нотатка:";

            textBoxSavingsNote.Font = new Font("Segoe UI", 10F);
            textBoxSavingsNote.Location = new Point(536, 52);
            textBoxSavingsNote.Size = new Size(298, 30);

            btnAddSavingsGoal.BackColor = Color.FromArgb(52, 152, 219);
            btnAddSavingsGoal.Cursor = Cursors.Hand;
            btnAddSavingsGoal.FlatAppearance.BorderSize = 0;
            btnAddSavingsGoal.FlatStyle = FlatStyle.Flat;
            btnAddSavingsGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddSavingsGoal.ForeColor = Color.White;
            btnAddSavingsGoal.Location = new Point(844, 44);
            btnAddSavingsGoal.Size = new Size(214, 46);
            btnAddSavingsGoal.Text = "Додати ціль";
            btnAddSavingsGoal.UseVisualStyleBackColor = false;
            btnAddSavingsGoal.Click += btnAddSavingsGoal_Click;

            // dataGridViewSavings
            dataGridViewSavings.AllowUserToAddRows = false;
            dataGridViewSavings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSavings.BackgroundColor = Color.White;
            dataGridViewSavings.BorderStyle = BorderStyle.None;
            dataGridViewSavings.ColumnHeadersHeight = 29;
            dataGridViewSavings.Location = new Point(10, 136);
            dataGridViewSavings.Name = "dataGridViewSavings";
            dataGridViewSavings.ReadOnly = true;
            dataGridViewSavings.RowHeadersVisible = false;
            dataGridViewSavings.RowHeadersWidth = 51;
            dataGridViewSavings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSavings.Size = new Size(1072, 274);

            // chartSavings  y=418  h=110
            chartSavings.Location = new Point(10, 418);
            chartSavings.Name = "chartSavings";
            chartSavings.Size = new Size(1072, 110);
            chartSavings.TabStop = false;

            // action row  y=536  h=130  bottom=666 < 676 ✓
            // three boxes side by side: deposit | delete | transfer
            int actY = 536, actH = 130;
            int actW = 342;  // (1072-16) / 3

            groupBoxDeposit.Controls.Add(labelDepositAmount);
            groupBoxDeposit.Controls.Add(textBoxDepositAmount);
            groupBoxDeposit.Controls.Add(btnDeposit);
            groupBoxDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDeposit.Location = new Point(10, actY);
            groupBoxDeposit.Name = "groupBoxDeposit";
            groupBoxDeposit.Size = new Size(actW, actH);
            groupBoxDeposit.TabStop = false;
            groupBoxDeposit.Text = "Поповнити обрану ціль";

            labelDepositAmount.AutoSize = true;
            labelDepositAmount.Font = new Font("Segoe UI", 9F);
            labelDepositAmount.Location = new Point(12, 28);
            labelDepositAmount.Text = "Сума (₴):";

            textBoxDepositAmount.Font = new Font("Segoe UI", 10F);
            textBoxDepositAmount.Location = new Point(12, 50);
            textBoxDepositAmount.Size = new Size(140, 30);

            btnDeposit.BackColor = Color.FromArgb(46, 204, 113);
            btnDeposit.Cursor = Cursors.Hand;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(160, 42);
            btnDeposit.Size = new Size(168, 46);
            btnDeposit.Text = "Відкласти";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;

            groupBox1.Controls.Add(btnDeleteSavingsGoal);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(360, actY);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(actW, actH);
            groupBox1.TabStop = false;
            groupBox1.Text = "Видалити обрану ціль";

            btnDeleteSavingsGoal.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteSavingsGoal.Cursor = Cursors.Hand;
            btnDeleteSavingsGoal.FlatAppearance.BorderSize = 0;
            btnDeleteSavingsGoal.FlatStyle = FlatStyle.Flat;
            btnDeleteSavingsGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteSavingsGoal.ForeColor = Color.White;
            btnDeleteSavingsGoal.Location = new Point(60, 42);
            btnDeleteSavingsGoal.Size = new Size(222, 46);
            btnDeleteSavingsGoal.Text = "Видалити ціль";
            btnDeleteSavingsGoal.UseVisualStyleBackColor = false;
            btnDeleteSavingsGoal.Click += btnDeleteSavingsGoal_Click;

            groupBoxTransfer.Controls.Add(labelTransferTo);
            groupBoxTransfer.Controls.Add(comboBoxTransferTo);
            groupBoxTransfer.Controls.Add(labelTransferAmount);
            groupBoxTransfer.Controls.Add(textBoxTransferAmount);
            groupBoxTransfer.Controls.Add(btnTransfer);
            groupBoxTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTransfer.Location = new Point(710, actY);
            groupBoxTransfer.Name = "groupBoxTransfer";
            groupBoxTransfer.Size = new Size(372, actH);
            groupBoxTransfer.TabStop = false;
            groupBoxTransfer.Text = "Переказ між цілями";

            labelTransferTo.AutoSize = true;
            labelTransferTo.Font = new Font("Segoe UI", 9F);
            labelTransferTo.Location = new Point(10, 28);
            labelTransferTo.Text = "В ціль:";

            comboBoxTransferTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransferTo.Font = new Font("Segoe UI", 10F);
            comboBoxTransferTo.Location = new Point(10, 50);
            comboBoxTransferTo.Size = new Size(190, 31);

            labelTransferAmount.AutoSize = true;
            labelTransferAmount.Font = new Font("Segoe UI", 9F);
            labelTransferAmount.Location = new Point(208, 28);
            labelTransferAmount.Text = "Сума (₴):";

            textBoxTransferAmount.Font = new Font("Segoe UI", 10F);
            textBoxTransferAmount.Location = new Point(208, 50);
            textBoxTransferAmount.Size = new Size(148, 30);

            btnTransfer.BackColor = Color.FromArgb(52, 152, 219);
            btnTransfer.Cursor = Cursors.Hand;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(208, 86);
            btnTransfer.Size = new Size(148, 36);
            btnTransfer.Text = "Переказати";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;

            // ── tabPageBudget ───────────────────────────────────────────
            // groupBoxAddBudget y=10 h=110 | grid y=128 h=480 | buttons y=616 h=48 → 664 < 676 ✓
            tabPageBudget.Controls.Add(groupBoxAddBudget);
            tabPageBudget.Controls.Add(dataGridViewBudget);
            tabPageBudget.Controls.Add(btnDeleteBudgetLimit);
            tabPageBudget.Controls.Add(btnGenerateReport);
            tabPageBudget.Location = new Point(4, 40);
            tabPageBudget.Name = "tabPageBudget";
            tabPageBudget.Padding = new Padding(10);
            tabPageBudget.Size = new Size(1092, 676);
            tabPageBudget.TabIndex = 4;
            tabPageBudget.Text = "Бюджет";

            groupBoxAddBudget.Controls.Add(labelBudgetCategory);
            groupBoxAddBudget.Controls.Add(comboBoxBudgetCategory);
            groupBoxAddBudget.Controls.Add(labelBudgetLimit);
            groupBoxAddBudget.Controls.Add(textBoxBudgetLimit);
            groupBoxAddBudget.Controls.Add(btnAddBudgetLimit);
            groupBoxAddBudget.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddBudget.Location = new Point(10, 10);
            groupBoxAddBudget.Name = "groupBoxAddBudget";
            groupBoxAddBudget.Size = new Size(1072, 110);
            groupBoxAddBudget.TabStop = false;
            groupBoxAddBudget.Text = "Встановити місячний ліміт";

            labelBudgetCategory.AutoSize = true;
            labelBudgetCategory.Font = new Font("Segoe UI", 9F);
            labelBudgetCategory.Location = new Point(14, 28);
            labelBudgetCategory.Text = "Категорія:";

            comboBoxBudgetCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBudgetCategory.Font = new Font("Segoe UI", 10F);
            comboBoxBudgetCategory.Location = new Point(14, 50);
            comboBoxBudgetCategory.Size = new Size(220, 31);

            labelBudgetLimit.AutoSize = true;
            labelBudgetLimit.Font = new Font("Segoe UI", 9F);
            labelBudgetLimit.Location = new Point(244, 28);
            labelBudgetLimit.Text = "Ліміт на місяць (₴):";

            textBoxBudgetLimit.Font = new Font("Segoe UI", 10F);
            textBoxBudgetLimit.Location = new Point(244, 50);
            textBoxBudgetLimit.Size = new Size(170, 30);

            btnAddBudgetLimit.BackColor = Color.FromArgb(155, 89, 182);
            btnAddBudgetLimit.Cursor = Cursors.Hand;
            btnAddBudgetLimit.FlatAppearance.BorderSize = 0;
            btnAddBudgetLimit.FlatStyle = FlatStyle.Flat;
            btnAddBudgetLimit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBudgetLimit.ForeColor = Color.White;
            btnAddBudgetLimit.Location = new Point(424, 44);
            btnAddBudgetLimit.Size = new Size(634, 42);
            btnAddBudgetLimit.Text = "Встановити ліміт";
            btnAddBudgetLimit.UseVisualStyleBackColor = false;
            btnAddBudgetLimit.Click += btnAddBudgetLimit_Click;

            dataGridViewBudget.AllowUserToAddRows = false;
            dataGridViewBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBudget.BackgroundColor = Color.White;
            dataGridViewBudget.BorderStyle = BorderStyle.None;
            dataGridViewBudget.ColumnHeadersHeight = 29;
            dataGridViewBudget.Location = new Point(10, 128);
            dataGridViewBudget.Name = "dataGridViewBudget";
            dataGridViewBudget.ReadOnly = true;
            dataGridViewBudget.RowHeadersVisible = false;
            dataGridViewBudget.RowHeadersWidth = 51;
            dataGridViewBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudget.Size = new Size(1072, 478);

            int budBtnY = 614, budBtnH = 48;
            btnGenerateReport.BackColor = Color.FromArgb(41, 128, 185);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(630, budBtnY);
            btnGenerateReport.Size = new Size(220, budBtnH);
            btnGenerateReport.Text = "Згенерувати PDF звіт";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;

            btnDeleteBudgetLimit.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteBudgetLimit.Cursor = Cursors.Hand;
            btnDeleteBudgetLimit.FlatAppearance.BorderSize = 0;
            btnDeleteBudgetLimit.FlatStyle = FlatStyle.Flat;
            btnDeleteBudgetLimit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBudgetLimit.ForeColor = Color.White;
            btnDeleteBudgetLimit.Location = new Point(858, budBtnY);
            btnDeleteBudgetLimit.Size = new Size(224, budBtnH);
            btnDeleteBudgetLimit.Text = "Видалити ліміт";
            btnDeleteBudgetLimit.UseVisualStyleBackColor = false;
            btnDeleteBudgetLimit.Click += btnDeleteBudgetLimit_Click;

            // ── WealthTracker form ──────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 720);
            Controls.Add(tabControlMain);
            MinimumSize = new Size(1116, 755);
            Name = "WealthTracker";
            Text = "WealthTracker";
            Load += WealthTracker_Load;

            tabControlMain.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            panelStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWallet).EndInit();
            groupBoxAddTransaction.ResumeLayout(false);
            groupBoxAddTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRecurringDay).EndInit();
            tabPageTransactions.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            tabPageAnalytics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartLine).EndInit();
            tabPageSavings.ResumeLayout(false);
            groupBoxAddSavings.ResumeLayout(false);
            groupBoxAddSavings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartSavings).EndInit();
            groupBoxDeposit.ResumeLayout(false);
            groupBoxDeposit.PerformLayout();
            groupBoxTransfer.ResumeLayout(false);
            groupBoxTransfer.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private TabPage tabPageSavings;
        private TabPage tabPageBudget;
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
        private Label labelNote;
        private TextBox textBoxNote;
        private CheckBox checkBoxRecurring;
        private Label labelRecurringDay;
        private NumericUpDown numericRecurringDay;
        private Button btnAddTransaction;
        private Panel panelFilter;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private CheckBox checkBoxFilterDate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private DataGridView dataGridViewTransactions;
        private Button btnFilter;
        private Button btnClearFilter;
        private Button btnExport;
        private Button btnSaveXml;
        private Button btnDeleteTransaction;
        private Chart chartPie;
        private Chart chartLine;
        private Chart chartSavings;
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
        private GroupBox groupBox1;
        private Button btnDeleteSavingsGoal;
        private GroupBox groupBoxTransfer;
        private Label labelTransferTo;
        private ComboBox comboBoxTransferTo;
        private Label labelTransferAmount;
        private TextBox textBoxTransferAmount;
        private Button btnTransfer;
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