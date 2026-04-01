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
            groupBoxDeposit = new GroupBox();
            labelDepositAmount = new Label();
            textBoxDepositAmount = new TextBox();
            btnDeposit = new Button();
            groupBox1 = new GroupBox();
            btnDeleteSavingsGoal = new Button();
            groupBoxTransfer = new GroupBox();
            labelTransferTo = new Label();
            btnTransfer = new Button();
            comboBoxTransferTo = new ComboBox();
            labelTransferAmount = new Label();
            textBoxTransferAmount = new TextBox();
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
            tabPageSavings.SuspendLayout();
            groupBoxAddSavings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).BeginInit();
            groupBoxDeposit.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxTransfer.SuspendLayout();
            tabPageBudget.SuspendLayout();
            groupBoxAddBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudget).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageDashboard);
            tabControlMain.Controls.Add(tabPageTransactions);
            tabControlMain.Controls.Add(tabPageAnalytics);
            tabControlMain.Controls.Add(tabPageSavings);
            tabControlMain.Controls.Add(tabPageBudget);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10F);
            tabControlMain.ItemSize = new Size(140, 36);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(3, 2, 3, 2);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(962, 582);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(panelStatistics);
            tabPageDashboard.Controls.Add(pictureBoxWallet);
            tabPageDashboard.Controls.Add(groupBoxAddTransaction);
            tabPageDashboard.Location = new Point(4, 40);
            tabPageDashboard.Margin = new Padding(3, 2, 3, 2);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(9, 8, 9, 8);
            tabPageDashboard.Size = new Size(954, 538);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Головна";
            // 
            // panelStatistics
            // 
            panelStatistics.BackColor = Color.FromArgb(236, 240, 241);
            panelStatistics.Controls.Add(labelBalance);
            panelStatistics.Controls.Add(labelTotalIncome);
            panelStatistics.Controls.Add(labelTotalExpenses);
            panelStatistics.Controls.Add(labelTransactionCount);
            panelStatistics.Controls.Add(labelForecast);
            panelStatistics.Location = new Point(9, 8);
            panelStatistics.Margin = new Padding(3, 2, 3, 2);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(938, 75);
            panelStatistics.TabIndex = 0;
            // 
            // labelBalance
            // 
            labelBalance.BackColor = Color.White;
            labelBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelBalance.ForeColor = Color.FromArgb(44, 62, 80);
            labelBalance.Location = new Point(5, 8);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(175, 60);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Баланс\n0.00 ₴";
            labelBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.BackColor = Color.White;
            labelTotalIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalIncome.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalIncome.Location = new Point(187, 8);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(175, 60);
            labelTotalIncome.TabIndex = 1;
            labelTotalIncome.Text = "Доходи\n0.00 ₴";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalExpenses
            // 
            labelTotalExpenses.BackColor = Color.White;
            labelTotalExpenses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalExpenses.ForeColor = Color.FromArgb(192, 57, 43);
            labelTotalExpenses.Location = new Point(369, 8);
            labelTotalExpenses.Name = "labelTotalExpenses";
            labelTotalExpenses.Size = new Size(175, 60);
            labelTotalExpenses.TabIndex = 2;
            labelTotalExpenses.Text = "Витрати\n0.00 ₴";
            labelTotalExpenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTransactionCount
            // 
            labelTransactionCount.BackColor = Color.White;
            labelTransactionCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTransactionCount.ForeColor = Color.FromArgb(44, 62, 80);
            labelTransactionCount.Location = new Point(551, 8);
            labelTransactionCount.Name = "labelTransactionCount";
            labelTransactionCount.Size = new Size(175, 60);
            labelTransactionCount.TabIndex = 3;
            labelTransactionCount.Text = "Транзакцій: 0";
            labelTransactionCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelForecast
            // 
            labelForecast.BackColor = Color.FromArgb(214, 234, 248);
            labelForecast.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelForecast.ForeColor = Color.FromArgb(44, 62, 80);
            labelForecast.Location = new Point(733, 8);
            labelForecast.Name = "labelForecast";
            labelForecast.Size = new Size(200, 60);
            labelForecast.TabIndex = 4;
            labelForecast.Text = "Прогноз на кінець місяця\n0.00 ₴";
            labelForecast.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWallet
            // 
            pictureBoxWallet.BackColor = Color.White;
            pictureBoxWallet.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxWallet.Location = new Point(9, 90);
            pictureBoxWallet.Margin = new Padding(3, 2, 3, 2);
            pictureBoxWallet.Name = "pictureBoxWallet";
            pictureBoxWallet.Size = new Size(284, 275);
            pictureBoxWallet.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxWallet.TabIndex = 1;
            pictureBoxWallet.TabStop = false;
            // 
            // groupBoxAddTransaction
            // 
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
            groupBoxAddTransaction.Location = new Point(299, 90);
            groupBoxAddTransaction.Margin = new Padding(3, 2, 3, 2);
            groupBoxAddTransaction.Name = "groupBoxAddTransaction";
            groupBoxAddTransaction.Padding = new Padding(3, 2, 3, 2);
            groupBoxAddTransaction.Size = new Size(647, 275);
            groupBoxAddTransaction.TabIndex = 2;
            groupBoxAddTransaction.TabStop = false;
            groupBoxAddTransaction.Text = "Додати транзакцію";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F);
            labelType.Location = new Point(16, 47);
            labelType.Name = "labelType";
            labelType.Size = new Size(88, 15);
            labelType.TabIndex = 0;
            labelType.Text = "Тип транзакції:";
            // 
            // radioButtonExpense
            // 
            radioButtonExpense.AutoSize = true;
            radioButtonExpense.Checked = true;
            radioButtonExpense.Font = new Font("Segoe UI", 9F);
            radioButtonExpense.Location = new Point(16, 65);
            radioButtonExpense.Margin = new Padding(3, 2, 3, 2);
            radioButtonExpense.Name = "radioButtonExpense";
            radioButtonExpense.Size = new Size(68, 19);
            radioButtonExpense.TabIndex = 1;
            radioButtonExpense.TabStop = true;
            radioButtonExpense.Text = "Витрата";
            radioButtonExpense.CheckedChanged += radioButtonExpense_CheckedChanged;
            // 
            // radioButtonIncome
            // 
            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Font = new Font("Segoe UI", 9F);
            radioButtonIncome.Location = new Point(118, 65);
            radioButtonIncome.Margin = new Padding(3, 2, 3, 2);
            radioButtonIncome.Name = "radioButtonIncome";
            radioButtonIncome.Size = new Size(55, 19);
            radioButtonIncome.TabIndex = 2;
            radioButtonIncome.Text = "Дохід";
            radioButtonIncome.CheckedChanged += radioButtonIncome_CheckedChanged;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 9F);
            labelCategory.Location = new Point(16, 94);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(62, 15);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "Категорія:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(16, 110);
            comboBoxCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(184, 25);
            comboBoxCategory.TabIndex = 4;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F);
            labelAmount.Location = new Point(16, 144);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(56, 15);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Сума (₴):";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 10F);
            textBoxAmount.Location = new Point(16, 161);
            textBoxAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(184, 25);
            textBoxAmount.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(221, 47);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(35, 15);
            labelDate.TabIndex = 7;
            labelDate.Text = "Дата:";
            // 
            // dateTimePickerTransaction
            // 
            dateTimePickerTransaction.Font = new Font("Segoe UI", 10F);
            dateTimePickerTransaction.Format = DateTimePickerFormat.Short;
            dateTimePickerTransaction.Location = new Point(221, 65);
            dateTimePickerTransaction.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            dateTimePickerTransaction.Size = new Size(149, 25);
            dateTimePickerTransaction.TabIndex = 8;
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Font = new Font("Segoe UI", 9F);
            labelNote.Location = new Point(391, 30);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(54, 15);
            labelNote.TabIndex = 9;
            labelNote.Text = "Нотатка:";
            // 
            // textBoxNote
            // 
            textBoxNote.Font = new Font("Segoe UI", 10F);
            textBoxNote.Location = new Point(391, 47);
            textBoxNote.Margin = new Padding(3, 2, 3, 2);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(239, 139);
            textBoxNote.TabIndex = 10;
            // 
            // checkBoxRecurring
            // 
            checkBoxRecurring.AutoSize = true;
            checkBoxRecurring.Font = new Font("Segoe UI", 9F);
            checkBoxRecurring.Location = new Point(221, 165);
            checkBoxRecurring.Margin = new Padding(3, 2, 3, 2);
            checkBoxRecurring.Name = "checkBoxRecurring";
            checkBoxRecurring.Size = new Size(102, 19);
            checkBoxRecurring.TabIndex = 11;
            checkBoxRecurring.Text = "Повторювана";
            checkBoxRecurring.CheckedChanged += checkBoxRecurring_CheckedChanged;
            // 
            // labelRecurringDay
            // 
            labelRecurringDay.AutoSize = true;
            labelRecurringDay.Font = new Font("Segoe UI", 9F);
            labelRecurringDay.Location = new Point(221, 94);
            labelRecurringDay.Name = "labelRecurringDay";
            labelRecurringDay.Size = new Size(77, 15);
            labelRecurringDay.TabIndex = 12;
            labelRecurringDay.Text = "День місяця:";
            labelRecurringDay.Visible = false;
            // 
            // numericRecurringDay
            // 
            numericRecurringDay.Font = new Font("Segoe UI", 10F);
            numericRecurringDay.Location = new Point(221, 110);
            numericRecurringDay.Margin = new Padding(3, 2, 3, 2);
            numericRecurringDay.Maximum = new decimal(new int[] { 28, 0, 0, 0 });
            numericRecurringDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRecurringDay.Name = "numericRecurringDay";
            numericRecurringDay.Size = new Size(149, 25);
            numericRecurringDay.TabIndex = 13;
            numericRecurringDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericRecurringDay.Visible = false;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.BackColor = Color.FromArgb(46, 204, 113);
            btnAddTransaction.Cursor = Cursors.Hand;
            btnAddTransaction.FlatAppearance.BorderSize = 0;
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTransaction.ForeColor = Color.White;
            btnAddTransaction.Location = new Point(16, 210);
            btnAddTransaction.Margin = new Padding(3, 2, 3, 2);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(614, 43);
            btnAddTransaction.TabIndex = 14;
            btnAddTransaction.Text = "Додати транзакцію";
            btnAddTransaction.UseVisualStyleBackColor = false;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // tabPageTransactions
            // 
            tabPageTransactions.Controls.Add(panelFilter);
            tabPageTransactions.Controls.Add(dataGridViewTransactions);
            tabPageTransactions.Controls.Add(btnDeleteTransaction);
            tabPageTransactions.Controls.Add(btnExport);
            tabPageTransactions.Controls.Add(btnSaveXml);
            tabPageTransactions.Controls.Add(btnClearFilter);
            tabPageTransactions.Controls.Add(btnFilter);
            tabPageTransactions.Location = new Point(4, 40);
            tabPageTransactions.Margin = new Padding(3, 2, 3, 2);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Padding = new Padding(9, 8, 9, 8);
            tabPageTransactions.Size = new Size(954, 538);
            tabPageTransactions.TabIndex = 1;
            tabPageTransactions.Text = "Транзакції";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.FromArgb(245, 245, 245);
            panelFilter.Controls.Add(labelSearch);
            panelFilter.Controls.Add(textBoxSearch);
            panelFilter.Controls.Add(checkBoxFilterDate);
            panelFilter.Controls.Add(dateTimePickerStart);
            panelFilter.Controls.Add(dateTimePickerEnd);
            panelFilter.Location = new Point(9, 8);
            panelFilter.Margin = new Padding(3, 2, 3, 2);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(938, 38);
            panelFilter.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(741, 9);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(55, 19);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Пошук:";
            labelSearch.Click += labelSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(802, 6);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(121, 25);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // checkBoxFilterDate
            // 
            checkBoxFilterDate.AutoSize = true;
            checkBoxFilterDate.Font = new Font("Segoe UI", 9F);
            checkBoxFilterDate.Location = new Point(9, 10);
            checkBoxFilterDate.Margin = new Padding(3, 2, 3, 2);
            checkBoxFilterDate.Name = "checkBoxFilterDate";
            checkBoxFilterDate.Size = new Size(79, 19);
            checkBoxFilterDate.TabIndex = 2;
            checkBoxFilterDate.Text = "За датою:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 9F);
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(101, 10);
            dateTimePickerStart.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(114, 23);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Segoe UI", 9F);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(223, 10);
            dateTimePickerEnd.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(114, 23);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.ColumnHeadersHeight = 29;
            dataGridViewTransactions.Location = new Point(9, 51);
            dataGridViewTransactions.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(938, 428);
            dataGridViewTransactions.TabIndex = 1;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteTransaction.Cursor = Cursors.Hand;
            btnDeleteTransaction.FlatAppearance.BorderSize = 0;
            btnDeleteTransaction.FlatStyle = FlatStyle.Flat;
            btnDeleteTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteTransaction.ForeColor = Color.White;
            btnDeleteTransaction.Location = new Point(798, 492);
            btnDeleteTransaction.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(149, 36);
            btnDeleteTransaction.TabIndex = 2;
            btnDeleteTransaction.Text = "Видалити обране";
            btnDeleteTransaction.UseVisualStyleBackColor = false;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(320, 492);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(149, 36);
            btnExport.TabIndex = 3;
            btnExport.Text = "Експорт (.csv)";
            btnExport.Click += btnExport_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.Location = new Point(476, 492);
            btnSaveXml.Margin = new Padding(3, 2, 3, 2);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(149, 36);
            btnSaveXml.TabIndex = 4;
            btnSaveXml.Text = "Зберегти (.xml)";
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(164, 492);
            btnClearFilter.Margin = new Padding(3, 2, 3, 2);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(149, 36);
            btnClearFilter.TabIndex = 5;
            btnClearFilter.Text = "Очистити фільтр";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(9, 492);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(149, 36);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;
            // 
            // tabPageAnalytics
            // 
            tabPageAnalytics.Location = new Point(4, 40);
            tabPageAnalytics.Margin = new Padding(3, 2, 3, 2);
            tabPageAnalytics.Name = "tabPageAnalytics";
            tabPageAnalytics.Padding = new Padding(9, 8, 9, 8);
            tabPageAnalytics.Size = new Size(954, 538);
            tabPageAnalytics.TabIndex = 2;
            tabPageAnalytics.Text = "Аналітика";
            // 
            // tabPageSavings
            // 
            tabPageSavings.Controls.Add(groupBoxAddSavings);
            tabPageSavings.Controls.Add(dataGridViewSavings);
            tabPageSavings.Controls.Add(groupBoxDeposit);
            tabPageSavings.Controls.Add(groupBox1);
            tabPageSavings.Controls.Add(groupBoxTransfer);
            tabPageSavings.Location = new Point(4, 40);
            tabPageSavings.Margin = new Padding(3, 2, 3, 2);
            tabPageSavings.Name = "tabPageSavings";
            tabPageSavings.Padding = new Padding(9, 8, 9, 8);
            tabPageSavings.Size = new Size(954, 538);
            tabPageSavings.TabIndex = 3;
            tabPageSavings.Text = "Тумбочка";
            // 
            // groupBoxAddSavings
            // 
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
            groupBoxAddSavings.Location = new Point(9, 8);
            groupBoxAddSavings.Margin = new Padding(3, 2, 3, 2);
            groupBoxAddSavings.Name = "groupBoxAddSavings";
            groupBoxAddSavings.Padding = new Padding(3, 2, 3, 2);
            groupBoxAddSavings.Size = new Size(938, 88);
            groupBoxAddSavings.TabIndex = 0;
            groupBoxAddSavings.TabStop = false;
            groupBoxAddSavings.Text = "Нова ціль заощадження";
            // 
            // labelSavingsName
            // 
            labelSavingsName.AutoSize = true;
            labelSavingsName.Font = new Font("Segoe UI", 9F);
            labelSavingsName.Location = new Point(12, 22);
            labelSavingsName.Name = "labelSavingsName";
            labelSavingsName.Size = new Size(42, 15);
            labelSavingsName.TabIndex = 0;
            labelSavingsName.Text = "Назва:";
            // 
            // textBoxSavingsName
            // 
            textBoxSavingsName.Font = new Font("Segoe UI", 10F);
            textBoxSavingsName.Location = new Point(12, 39);
            textBoxSavingsName.Margin = new Padding(3, 2, 3, 2);
            textBoxSavingsName.Name = "textBoxSavingsName";
            textBoxSavingsName.Size = new Size(172, 25);
            textBoxSavingsName.TabIndex = 1;
            // 
            // labelSavingsTarget
            // 
            labelSavingsTarget.AutoSize = true;
            labelSavingsTarget.Font = new Font("Segoe UI", 9F);
            labelSavingsTarget.Location = new Point(192, 22);
            labelSavingsTarget.Name = "labelSavingsTarget";
            labelSavingsTarget.Size = new Size(56, 15);
            labelSavingsTarget.TabIndex = 2;
            labelSavingsTarget.Text = "Сума (₴):";
            // 
            // textBoxSavingsTarget
            // 
            textBoxSavingsTarget.Font = new Font("Segoe UI", 10F);
            textBoxSavingsTarget.Location = new Point(192, 39);
            textBoxSavingsTarget.Margin = new Padding(3, 2, 3, 2);
            textBoxSavingsTarget.Name = "textBoxSavingsTarget";
            textBoxSavingsTarget.Size = new Size(130, 25);
            textBoxSavingsTarget.TabIndex = 3;
            // 
            // labelSavingsDeadline
            // 
            labelSavingsDeadline.AutoSize = true;
            labelSavingsDeadline.Font = new Font("Segoe UI", 9F);
            labelSavingsDeadline.Location = new Point(331, 22);
            labelSavingsDeadline.Name = "labelSavingsDeadline";
            labelSavingsDeadline.Size = new Size(57, 15);
            labelSavingsDeadline.TabIndex = 4;
            labelSavingsDeadline.Text = "Дедлайн:";
            // 
            // dateTimePickerSavingsDeadline
            // 
            dateTimePickerSavingsDeadline.Font = new Font("Segoe UI", 10F);
            dateTimePickerSavingsDeadline.Format = DateTimePickerFormat.Short;
            dateTimePickerSavingsDeadline.Location = new Point(331, 39);
            dateTimePickerSavingsDeadline.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerSavingsDeadline.MinDate = new DateTime(2026, 4, 3, 20, 44, 45, 712);
            dateTimePickerSavingsDeadline.Name = "dateTimePickerSavingsDeadline";
            dateTimePickerSavingsDeadline.Size = new Size(130, 25);
            dateTimePickerSavingsDeadline.TabIndex = 5;
            dateTimePickerSavingsDeadline.Value = new DateTime(2026, 10, 1, 20, 44, 45, 712);
            // 
            // labelSavingsNote
            // 
            labelSavingsNote.AutoSize = true;
            labelSavingsNote.Font = new Font("Segoe UI", 9F);
            labelSavingsNote.Location = new Point(469, 22);
            labelSavingsNote.Name = "labelSavingsNote";
            labelSavingsNote.Size = new Size(54, 15);
            labelSavingsNote.TabIndex = 6;
            labelSavingsNote.Text = "Нотатка:";
            // 
            // textBoxSavingsNote
            // 
            textBoxSavingsNote.Font = new Font("Segoe UI", 10F);
            textBoxSavingsNote.Location = new Point(469, 39);
            textBoxSavingsNote.Margin = new Padding(3, 2, 3, 2);
            textBoxSavingsNote.Name = "textBoxSavingsNote";
            textBoxSavingsNote.Size = new Size(261, 25);
            textBoxSavingsNote.TabIndex = 7;
            // 
            // btnAddSavingsGoal
            // 
            btnAddSavingsGoal.BackColor = Color.FromArgb(52, 152, 219);
            btnAddSavingsGoal.Cursor = Cursors.Hand;
            btnAddSavingsGoal.FlatAppearance.BorderSize = 0;
            btnAddSavingsGoal.FlatStyle = FlatStyle.Flat;
            btnAddSavingsGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddSavingsGoal.ForeColor = Color.White;
            btnAddSavingsGoal.Location = new Point(738, 33);
            btnAddSavingsGoal.Margin = new Padding(3, 2, 3, 2);
            btnAddSavingsGoal.Name = "btnAddSavingsGoal";
            btnAddSavingsGoal.Size = new Size(187, 34);
            btnAddSavingsGoal.TabIndex = 8;
            btnAddSavingsGoal.Text = "Додати ціль";
            btnAddSavingsGoal.UseVisualStyleBackColor = false;
            btnAddSavingsGoal.Click += btnAddSavingsGoal_Click;
            // 
            // dataGridViewSavings
            // 
            dataGridViewSavings.AllowUserToAddRows = false;
            dataGridViewSavings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSavings.BackgroundColor = Color.White;
            dataGridViewSavings.BorderStyle = BorderStyle.None;
            dataGridViewSavings.ColumnHeadersHeight = 29;
            dataGridViewSavings.Location = new Point(9, 102);
            dataGridViewSavings.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSavings.Name = "dataGridViewSavings";
            dataGridViewSavings.ReadOnly = true;
            dataGridViewSavings.RowHeadersVisible = false;
            dataGridViewSavings.RowHeadersWidth = 51;
            dataGridViewSavings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSavings.Size = new Size(938, 206);
            dataGridViewSavings.TabIndex = 1;
            // 
            // groupBoxDeposit
            // 
            groupBoxDeposit.Controls.Add(labelDepositAmount);
            groupBoxDeposit.Controls.Add(textBoxDepositAmount);
            groupBoxDeposit.Controls.Add(btnDeposit);
            groupBoxDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDeposit.Location = new Point(9, 402);
            groupBoxDeposit.Margin = new Padding(3, 2, 3, 2);
            groupBoxDeposit.Name = "groupBoxDeposit";
            groupBoxDeposit.Padding = new Padding(3, 2, 3, 2);
            groupBoxDeposit.Size = new Size(299, 126);
            groupBoxDeposit.TabIndex = 2;
            groupBoxDeposit.TabStop = false;
            groupBoxDeposit.Text = "Поповнити обрану ціль";
            // 
            // labelDepositAmount
            // 
            labelDepositAmount.AutoSize = true;
            labelDepositAmount.Font = new Font("Segoe UI", 9F);
            labelDepositAmount.Location = new Point(6, 21);
            labelDepositAmount.Name = "labelDepositAmount";
            labelDepositAmount.Size = new Size(56, 15);
            labelDepositAmount.TabIndex = 0;
            labelDepositAmount.Text = "Сума (₴):";
            // 
            // textBoxDepositAmount
            // 
            textBoxDepositAmount.Font = new Font("Segoe UI", 10F);
            textBoxDepositAmount.Location = new Point(6, 39);
            textBoxDepositAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxDepositAmount.Multiline = true;
            textBoxDepositAmount.Name = "textBoxDepositAmount";
            textBoxDepositAmount.Size = new Size(123, 72);
            textBoxDepositAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.FromArgb(46, 204, 113);
            btnDeposit.Cursor = Cursors.Hand;
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(136, 39);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(147, 72);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Відкласти";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteSavingsGoal);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(315, 402);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(299, 126);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Видалити обрану ціль";
            // 
            // btnDeleteSavingsGoal
            // 
            btnDeleteSavingsGoal.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteSavingsGoal.Cursor = Cursors.Hand;
            btnDeleteSavingsGoal.FlatAppearance.BorderSize = 0;
            btnDeleteSavingsGoal.FlatStyle = FlatStyle.Flat;
            btnDeleteSavingsGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteSavingsGoal.ForeColor = Color.White;
            btnDeleteSavingsGoal.Location = new Point(49, 39);
            btnDeleteSavingsGoal.Margin = new Padding(3, 2, 3, 2);
            btnDeleteSavingsGoal.Name = "btnDeleteSavingsGoal";
            btnDeleteSavingsGoal.Size = new Size(194, 70);
            btnDeleteSavingsGoal.TabIndex = 0;
            btnDeleteSavingsGoal.Text = "Видалити ціль";
            btnDeleteSavingsGoal.UseVisualStyleBackColor = false;
            btnDeleteSavingsGoal.Click += btnDeleteSavingsGoal_Click;
            // 
            // groupBoxTransfer
            // 
            groupBoxTransfer.Controls.Add(labelTransferTo);
            groupBoxTransfer.Controls.Add(btnTransfer);
            groupBoxTransfer.Controls.Add(comboBoxTransferTo);
            groupBoxTransfer.Controls.Add(labelTransferAmount);
            groupBoxTransfer.Controls.Add(textBoxTransferAmount);
            groupBoxTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTransfer.Location = new Point(621, 402);
            groupBoxTransfer.Margin = new Padding(3, 2, 3, 2);
            groupBoxTransfer.Name = "groupBoxTransfer";
            groupBoxTransfer.Padding = new Padding(3, 2, 3, 2);
            groupBoxTransfer.Size = new Size(326, 126);
            groupBoxTransfer.TabIndex = 4;
            groupBoxTransfer.TabStop = false;
            groupBoxTransfer.Text = "Переказ між цілями";
            // 
            // labelTransferTo
            // 
            labelTransferTo.AutoSize = true;
            labelTransferTo.Font = new Font("Segoe UI", 9F);
            labelTransferTo.Location = new Point(9, 21);
            labelTransferTo.Name = "labelTransferTo";
            labelTransferTo.Size = new Size(43, 15);
            labelTransferTo.TabIndex = 0;
            labelTransferTo.Text = "В ціль:";
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.FromArgb(52, 152, 219);
            btnTransfer.Cursor = Cursors.Hand;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(190, 38);
            btnTransfer.Margin = new Padding(3, 2, 3, 2);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(123, 70);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Переказати";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // comboBoxTransferTo
            // 
            comboBoxTransferTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransferTo.Font = new Font("Segoe UI", 10F);
            comboBoxTransferTo.Location = new Point(9, 38);
            comboBoxTransferTo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTransferTo.Name = "comboBoxTransferTo";
            comboBoxTransferTo.Size = new Size(167, 25);
            comboBoxTransferTo.TabIndex = 1;
            // 
            // labelTransferAmount
            // 
            labelTransferAmount.AutoSize = true;
            labelTransferAmount.Font = new Font("Segoe UI", 9F);
            labelTransferAmount.Location = new Point(9, 68);
            labelTransferAmount.Name = "labelTransferAmount";
            labelTransferAmount.Size = new Size(56, 15);
            labelTransferAmount.TabIndex = 2;
            labelTransferAmount.Text = "Сума (₴):";
            // 
            // textBoxTransferAmount
            // 
            textBoxTransferAmount.Font = new Font("Segoe UI", 10F);
            textBoxTransferAmount.Location = new Point(9, 83);
            textBoxTransferAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxTransferAmount.Name = "textBoxTransferAmount";
            textBoxTransferAmount.Size = new Size(167, 25);
            textBoxTransferAmount.TabIndex = 3;
            // 
            // tabPageBudget
            // 
            tabPageBudget.Controls.Add(groupBoxAddBudget);
            tabPageBudget.Controls.Add(dataGridViewBudget);
            tabPageBudget.Controls.Add(btnDeleteBudgetLimit);
            tabPageBudget.Controls.Add(btnGenerateReport);
            tabPageBudget.Location = new Point(4, 40);
            tabPageBudget.Margin = new Padding(3, 2, 3, 2);
            tabPageBudget.Name = "tabPageBudget";
            tabPageBudget.Padding = new Padding(9, 8, 9, 8);
            tabPageBudget.Size = new Size(954, 538);
            tabPageBudget.TabIndex = 4;
            tabPageBudget.Text = "Бюджет";
            // 
            // groupBoxAddBudget
            // 
            groupBoxAddBudget.Controls.Add(labelBudgetCategory);
            groupBoxAddBudget.Controls.Add(comboBoxBudgetCategory);
            groupBoxAddBudget.Controls.Add(labelBudgetLimit);
            groupBoxAddBudget.Controls.Add(textBoxBudgetLimit);
            groupBoxAddBudget.Controls.Add(btnAddBudgetLimit);
            groupBoxAddBudget.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddBudget.Location = new Point(9, 8);
            groupBoxAddBudget.Margin = new Padding(3, 2, 3, 2);
            groupBoxAddBudget.Name = "groupBoxAddBudget";
            groupBoxAddBudget.Padding = new Padding(3, 2, 3, 2);
            groupBoxAddBudget.Size = new Size(938, 82);
            groupBoxAddBudget.TabIndex = 0;
            groupBoxAddBudget.TabStop = false;
            groupBoxAddBudget.Text = "Встановити місячний ліміт";
            // 
            // labelBudgetCategory
            // 
            labelBudgetCategory.AutoSize = true;
            labelBudgetCategory.Font = new Font("Segoe UI", 9F);
            labelBudgetCategory.Location = new Point(12, 21);
            labelBudgetCategory.Name = "labelBudgetCategory";
            labelBudgetCategory.Size = new Size(62, 15);
            labelBudgetCategory.TabIndex = 0;
            labelBudgetCategory.Text = "Категорія:";
            // 
            // comboBoxBudgetCategory
            // 
            comboBoxBudgetCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBudgetCategory.Font = new Font("Segoe UI", 10F);
            comboBoxBudgetCategory.Location = new Point(12, 38);
            comboBoxBudgetCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxBudgetCategory.Name = "comboBoxBudgetCategory";
            comboBoxBudgetCategory.Size = new Size(193, 25);
            comboBoxBudgetCategory.TabIndex = 1;
            // 
            // labelBudgetLimit
            // 
            labelBudgetLimit.AutoSize = true;
            labelBudgetLimit.Font = new Font("Segoe UI", 9F);
            labelBudgetLimit.Location = new Point(214, 21);
            labelBudgetLimit.Name = "labelBudgetLimit";
            labelBudgetLimit.Size = new Size(111, 15);
            labelBudgetLimit.TabIndex = 2;
            labelBudgetLimit.Text = "Ліміт на місяць (₴):";
            // 
            // textBoxBudgetLimit
            // 
            textBoxBudgetLimit.Font = new Font("Segoe UI", 10F);
            textBoxBudgetLimit.Location = new Point(214, 38);
            textBoxBudgetLimit.Margin = new Padding(3, 2, 3, 2);
            textBoxBudgetLimit.Name = "textBoxBudgetLimit";
            textBoxBudgetLimit.Size = new Size(149, 25);
            textBoxBudgetLimit.TabIndex = 3;
            // 
            // btnAddBudgetLimit
            // 
            btnAddBudgetLimit.BackColor = Color.FromArgb(155, 89, 182);
            btnAddBudgetLimit.Cursor = Cursors.Hand;
            btnAddBudgetLimit.FlatAppearance.BorderSize = 0;
            btnAddBudgetLimit.FlatStyle = FlatStyle.Flat;
            btnAddBudgetLimit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBudgetLimit.ForeColor = Color.White;
            btnAddBudgetLimit.Location = new Point(371, 21);
            btnAddBudgetLimit.Margin = new Padding(3, 2, 3, 2);
            btnAddBudgetLimit.Name = "btnAddBudgetLimit";
            btnAddBudgetLimit.Size = new Size(555, 42);
            btnAddBudgetLimit.TabIndex = 4;
            btnAddBudgetLimit.Text = "Встановити ліміт";
            btnAddBudgetLimit.UseVisualStyleBackColor = false;
            btnAddBudgetLimit.Click += btnAddBudgetLimit_Click;
            // 
            // dataGridViewBudget
            // 
            dataGridViewBudget.AllowUserToAddRows = false;
            dataGridViewBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBudget.BackgroundColor = Color.White;
            dataGridViewBudget.BorderStyle = BorderStyle.None;
            dataGridViewBudget.ColumnHeadersHeight = 29;
            dataGridViewBudget.Location = new Point(9, 96);
            dataGridViewBudget.Margin = new Padding(3, 2, 3, 2);
            dataGridViewBudget.Name = "dataGridViewBudget";
            dataGridViewBudget.ReadOnly = true;
            dataGridViewBudget.RowHeadersVisible = false;
            dataGridViewBudget.RowHeadersWidth = 51;
            dataGridViewBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudget.Size = new Size(938, 353);
            dataGridViewBudget.TabIndex = 1;
            // 
            // btnDeleteBudgetLimit
            // 
            btnDeleteBudgetLimit.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteBudgetLimit.Cursor = Cursors.Hand;
            btnDeleteBudgetLimit.FlatAppearance.BorderSize = 0;
            btnDeleteBudgetLimit.FlatStyle = FlatStyle.Flat;
            btnDeleteBudgetLimit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBudgetLimit.ForeColor = Color.White;
            btnDeleteBudgetLimit.Location = new Point(751, 458);
            btnDeleteBudgetLimit.Margin = new Padding(3, 2, 3, 2);
            btnDeleteBudgetLimit.Name = "btnDeleteBudgetLimit";
            btnDeleteBudgetLimit.Size = new Size(196, 73);
            btnDeleteBudgetLimit.TabIndex = 2;
            btnDeleteBudgetLimit.Text = "Видалити ліміт";
            btnDeleteBudgetLimit.UseVisualStyleBackColor = false;
            btnDeleteBudgetLimit.Click += btnDeleteBudgetLimit_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(41, 128, 185);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(553, 458);
            btnGenerateReport.Margin = new Padding(3, 2, 3, 2);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(192, 73);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Згенерувати PDF звіт";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // WealthTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 582);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(978, 576);
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
            tabPageSavings.ResumeLayout(false);
            groupBoxAddSavings.ResumeLayout(false);
            groupBoxAddSavings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).EndInit();
            groupBoxDeposit.ResumeLayout(false);
            groupBoxDeposit.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBoxTransfer.ResumeLayout(false);
            groupBoxTransfer.PerformLayout();
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