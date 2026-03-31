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
            groupBoxTransfer = new GroupBox();
            labelTransferTo = new Label();
            comboBoxTransferTo = new ComboBox();
            labelTransferAmount = new Label();
            textBoxTransferAmount = new TextBox();
            btnTransfer = new Button();
            groupBoxDeposit = new GroupBox();
            labelDepositAmount = new Label();
            textBoxDepositAmount = new TextBox();
            btnDeposit = new Button();
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
            tabPageSavings.SuspendLayout();
            groupBoxAddSavings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).BeginInit();
            groupBoxTransfer.SuspendLayout();
            groupBoxDeposit.SuspendLayout();
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
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1100, 739);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(panelStatistics);
            tabPageDashboard.Controls.Add(pictureBoxWallet);
            tabPageDashboard.Controls.Add(groupBoxAddTransaction);
            tabPageDashboard.Location = new Point(4, 40);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(10, 10, 10, 10);
            tabPageDashboard.Size = new Size(1092, 695);
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
            panelStatistics.Location = new Point(10, 13);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(1068, 137);
            panelStatistics.TabIndex = 0;
            // 
            // labelBalance
            // 
            labelBalance.BackColor = Color.White;
            labelBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelBalance.ForeColor = Color.FromArgb(44, 62, 80);
            labelBalance.Location = new Point(9, 10);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(200, 112);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Баланс\n0.00 ₴";
            labelBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.BackColor = Color.White;
            labelTotalIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalIncome.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalIncome.Location = new Point(219, 10);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(200, 112);
            labelTotalIncome.TabIndex = 1;
            labelTotalIncome.Text = "Доходи\n0.00 ₴";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalExpenses
            // 
            labelTotalExpenses.BackColor = Color.White;
            labelTotalExpenses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalExpenses.ForeColor = Color.FromArgb(192, 57, 43);
            labelTotalExpenses.Location = new Point(429, 10);
            labelTotalExpenses.Name = "labelTotalExpenses";
            labelTotalExpenses.Size = new Size(200, 112);
            labelTotalExpenses.TabIndex = 2;
            labelTotalExpenses.Text = "Витрати\n0.00 ₴";
            labelTotalExpenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTransactionCount
            // 
            labelTransactionCount.BackColor = Color.White;
            labelTransactionCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTransactionCount.ForeColor = Color.FromArgb(44, 62, 80);
            labelTransactionCount.Location = new Point(639, 10);
            labelTransactionCount.Name = "labelTransactionCount";
            labelTransactionCount.Size = new Size(200, 112);
            labelTransactionCount.TabIndex = 3;
            labelTransactionCount.Text = "Транзакцій: 0";
            labelTransactionCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelForecast
            // 
            labelForecast.BackColor = Color.FromArgb(214, 234, 248);
            labelForecast.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelForecast.ForeColor = Color.FromArgb(44, 62, 80);
            labelForecast.Location = new Point(849, 10);
            labelForecast.Name = "labelForecast";
            labelForecast.Size = new Size(210, 112);
            labelForecast.TabIndex = 4;
            labelForecast.Text = "Прогноз на кінець місяця\n0.00 ₴";
            labelForecast.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWallet
            // 
            pictureBoxWallet.BackColor = Color.White;
            pictureBoxWallet.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxWallet.Location = new Point(10, 157);
            pictureBoxWallet.Name = "pictureBoxWallet";
            pictureBoxWallet.Size = new Size(245, 261);
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
            groupBoxAddTransaction.Location = new Point(268, 157);
            groupBoxAddTransaction.Name = "groupBoxAddTransaction";
            groupBoxAddTransaction.Size = new Size(800, 260);
            groupBoxAddTransaction.TabIndex = 2;
            groupBoxAddTransaction.TabStop = false;
            groupBoxAddTransaction.Text = "Додати транзакцію";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F);
            labelType.Location = new Point(15, 30);
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
            radioButtonExpense.Location = new Point(15, 52);
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
            radioButtonIncome.Location = new Point(140, 52);
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
            labelCategory.Location = new Point(15, 89);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(62, 15);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "Категорія:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(13, 107);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(221, 25);
            comboBoxCategory.TabIndex = 4;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F);
            labelAmount.Location = new Point(13, 145);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(56, 15);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Сума (₴):";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 10F);
            textBoxAmount.Location = new Point(13, 164);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(221, 25);
            textBoxAmount.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(265, 29);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(35, 15);
            labelDate.TabIndex = 7;
            labelDate.Text = "Дата:";
            // 
            // dateTimePickerTransaction
            // 
            dateTimePickerTransaction.Font = new Font("Segoe UI", 10F);
            dateTimePickerTransaction.Format = DateTimePickerFormat.Short;
            dateTimePickerTransaction.Location = new Point(265, 47);
            dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            dateTimePickerTransaction.Size = new Size(163, 25);
            dateTimePickerTransaction.TabIndex = 8;
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Font = new Font("Segoe UI", 9F);
            labelNote.Location = new Point(452, 20);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(54, 15);
            labelNote.TabIndex = 9;
            labelNote.Text = "Нотатка:";
            // 
            // textBoxNote
            // 
            textBoxNote.Font = new Font("Segoe UI", 10F);
            textBoxNote.Location = new Point(452, 39);
            textBoxNote.Margin = new Padding(3, 2, 3, 2);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(330, 142);
            textBoxNote.TabIndex = 10;
            // 
            // checkBoxRecurring
            // 
            checkBoxRecurring.AutoSize = true;
            checkBoxRecurring.Font = new Font("Segoe UI", 9F);
            checkBoxRecurring.Location = new Point(265, 164);
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
            labelRecurringDay.Location = new Point(265, 89);
            labelRecurringDay.Name = "labelRecurringDay";
            labelRecurringDay.Size = new Size(77, 15);
            labelRecurringDay.TabIndex = 12;
            labelRecurringDay.Text = "День місяця:";
            labelRecurringDay.Visible = false;
            // 
            // numericRecurringDay
            // 
            numericRecurringDay.Font = new Font("Segoe UI", 10F);
            numericRecurringDay.Location = new Point(265, 106);
            numericRecurringDay.Margin = new Padding(3, 2, 3, 2);
            numericRecurringDay.Maximum = new decimal(new int[] { 28, 0, 0, 0 });
            numericRecurringDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRecurringDay.Name = "numericRecurringDay";
            numericRecurringDay.Size = new Size(163, 25);
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
            btnAddTransaction.Location = new Point(13, 200);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(768, 48);
            btnAddTransaction.TabIndex = 9;
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
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Padding = new Padding(10, 10, 10, 10);
            tabPageTransactions.Size = new Size(1092, 695);
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
            panelFilter.Location = new Point(10, 10);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1068, 55);
            panelFilter.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(1020, 14);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(0, 19);
            labelSearch.TabIndex = 0;
            labelSearch.Click += labelSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(830, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(180, 25);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // checkBoxFilterDate
            // 
            checkBoxFilterDate.AutoSize = true;
            checkBoxFilterDate.Font = new Font("Segoe UI", 9F);
            checkBoxFilterDate.Location = new Point(14, 16);
            checkBoxFilterDate.Name = "checkBoxFilterDate";
            checkBoxFilterDate.Size = new Size(79, 19);
            checkBoxFilterDate.TabIndex = 2;
            checkBoxFilterDate.Text = "За датою:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 9F);
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(117, 14);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(116, 23);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Segoe UI", 9F);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(245, 14);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(116, 23);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.ColumnHeadersHeight = 29;
            dataGridViewTransactions.Location = new Point(10, 77);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(1068, 527);
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
            btnDeleteTransaction.Location = new Point(882, 623);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(197, 59);
            btnDeleteTransaction.TabIndex = 2;
            btnDeleteTransaction.Text = "Видалити обране";
            btnDeleteTransaction.UseVisualStyleBackColor = false;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(339, 623);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(152, 59);
            btnExport.TabIndex = 3;
            btnExport.Text = "Експорт (.csv)";
            btnExport.Click += btnExport_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.Location = new Point(500, 623);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(152, 59);
            btnSaveXml.TabIndex = 4;
            btnSaveXml.Text = "Зберегти (.xml)";
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(172, 623);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(152, 59);
            btnClearFilter.TabIndex = 5;
            btnClearFilter.Text = "Очистити фільтр";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(11, 623);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(152, 59);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;
            // 
            // tabPageAnalytics
            // 
            tabPageAnalytics.Location = new Point(4, 40);
            tabPageAnalytics.Name = "tabPageAnalytics";
            tabPageAnalytics.Padding = new Padding(10, 10, 10, 10);
            tabPageAnalytics.Size = new Size(1092, 695);
            tabPageAnalytics.TabIndex = 2;
            tabPageAnalytics.Text = "Аналітика";
            // 
            // tabPageSavings
            // 
            tabPageSavings.Controls.Add(groupBoxAddSavings);
            tabPageSavings.Controls.Add(dataGridViewSavings);
            tabPageSavings.Controls.Add(groupBoxTransfer);
            tabPageSavings.Controls.Add(groupBoxDeposit);
            tabPageSavings.Controls.Add(btnDeleteSavingsGoal);
            tabPageSavings.Location = new Point(4, 40);
            tabPageSavings.Name = "tabPageSavings";
            tabPageSavings.Padding = new Padding(10, 10, 10, 10);
            tabPageSavings.Size = new Size(1092, 695);
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
            groupBoxAddSavings.Location = new Point(10, 10);
            groupBoxAddSavings.Name = "groupBoxAddSavings";
            groupBoxAddSavings.Size = new Size(1068, 160);
            groupBoxAddSavings.TabIndex = 0;
            groupBoxAddSavings.TabStop = false;
            groupBoxAddSavings.Text = "Нова ціль заощадження";
            // 
            // labelSavingsName
            // 
            labelSavingsName.AutoSize = true;
            labelSavingsName.Font = new Font("Segoe UI", 9F);
            labelSavingsName.Location = new Point(15, 30);
            labelSavingsName.Name = "labelSavingsName";
            labelSavingsName.Size = new Size(42, 15);
            labelSavingsName.TabIndex = 0;
            labelSavingsName.Text = "Назва:";
            // 
            // textBoxSavingsName
            // 
            textBoxSavingsName.Font = new Font("Segoe UI", 10F);
            textBoxSavingsName.Location = new Point(15, 50);
            textBoxSavingsName.Name = "textBoxSavingsName";
            textBoxSavingsName.Size = new Size(220, 25);
            textBoxSavingsName.TabIndex = 1;
            // 
            // labelSavingsTarget
            // 
            labelSavingsTarget.AutoSize = true;
            labelSavingsTarget.Font = new Font("Segoe UI", 9F);
            labelSavingsTarget.Location = new Point(250, 30);
            labelSavingsTarget.Name = "labelSavingsTarget";
            labelSavingsTarget.Size = new Size(79, 15);
            labelSavingsTarget.TabIndex = 2;
            labelSavingsTarget.Text = "Сума цілі (₴):";
            // 
            // textBoxSavingsTarget
            // 
            textBoxSavingsTarget.Font = new Font("Segoe UI", 10F);
            textBoxSavingsTarget.Location = new Point(250, 50);
            textBoxSavingsTarget.Name = "textBoxSavingsTarget";
            textBoxSavingsTarget.Size = new Size(160, 25);
            textBoxSavingsTarget.TabIndex = 3;
            // 
            // labelSavingsDeadline
            // 
            labelSavingsDeadline.AutoSize = true;
            labelSavingsDeadline.Font = new Font("Segoe UI", 9F);
            labelSavingsDeadline.Location = new Point(425, 30);
            labelSavingsDeadline.Name = "labelSavingsDeadline";
            labelSavingsDeadline.Size = new Size(57, 15);
            labelSavingsDeadline.TabIndex = 4;
            labelSavingsDeadline.Text = "Дедлайн:";
            // 
            // dateTimePickerSavingsDeadline
            // 
            dateTimePickerSavingsDeadline.Font = new Font("Segoe UI", 10F);
            dateTimePickerSavingsDeadline.Format = DateTimePickerFormat.Short;
            dateTimePickerSavingsDeadline.Location = new Point(425, 50);
            dateTimePickerSavingsDeadline.MinDate = new DateTime(2026, 4, 2, 20, 10, 57, 102);
            dateTimePickerSavingsDeadline.Name = "dateTimePickerSavingsDeadline";
            dateTimePickerSavingsDeadline.Size = new Size(160, 25);
            dateTimePickerSavingsDeadline.TabIndex = 5;
            dateTimePickerSavingsDeadline.Value = new DateTime(2026, 9, 30, 9, 36, 50, 152);
            // 
            // labelSavingsNote
            // 
            labelSavingsNote.AutoSize = true;
            labelSavingsNote.Font = new Font("Segoe UI", 9F);
            labelSavingsNote.Location = new Point(600, 30);
            labelSavingsNote.Name = "labelSavingsNote";
            labelSavingsNote.Size = new Size(145, 15);
            labelSavingsNote.TabIndex = 6;
            labelSavingsNote.Text = "Нотатка (необов'язково):";
            // 
            // textBoxSavingsNote
            // 
            textBoxSavingsNote.Font = new Font("Segoe UI", 10F);
            textBoxSavingsNote.Location = new Point(600, 50);
            textBoxSavingsNote.Name = "textBoxSavingsNote";
            textBoxSavingsNote.Size = new Size(280, 25);
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
            btnAddSavingsGoal.Location = new Point(15, 100);
            btnAddSavingsGoal.Name = "btnAddSavingsGoal";
            btnAddSavingsGoal.Size = new Size(1038, 44);
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
            dataGridViewSavings.Location = new Point(10, 180);
            dataGridViewSavings.Name = "dataGridViewSavings";
            dataGridViewSavings.ReadOnly = true;
            dataGridViewSavings.RowHeadersVisible = false;
            dataGridViewSavings.RowHeadersWidth = 51;
            dataGridViewSavings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSavings.Size = new Size(1068, 350);
            dataGridViewSavings.TabIndex = 1;
            // 
            // groupBoxTransfer
            // 
            groupBoxTransfer.Controls.Add(labelTransferTo);
            groupBoxTransfer.Controls.Add(comboBoxTransferTo);
            groupBoxTransfer.Controls.Add(labelTransferAmount);
            groupBoxTransfer.Controls.Add(textBoxTransferAmount);
            groupBoxTransfer.Controls.Add(btnTransfer);
            groupBoxTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTransfer.Location = new Point(422, 541);
            groupBoxTransfer.Margin = new Padding(3, 2, 3, 2);
            groupBoxTransfer.Name = "groupBoxTransfer";
            groupBoxTransfer.Padding = new Padding(3, 2, 3, 2);
            groupBoxTransfer.Size = new Size(352, 142);
            groupBoxTransfer.TabIndex = 2;
            groupBoxTransfer.TabStop = false;
            groupBoxTransfer.Text = "Переказ між цілями";
            // 
            // labelTransferTo
            // 
            labelTransferTo.AutoSize = true;
            labelTransferTo.Font = new Font("Segoe UI", 9F);
            labelTransferTo.Location = new Point(13, 21);
            labelTransferTo.Name = "labelTransferTo";
            labelTransferTo.Size = new Size(43, 15);
            labelTransferTo.TabIndex = 0;
            labelTransferTo.Text = "В ціль:";
            // 
            // comboBoxTransferTo
            // 
            comboBoxTransferTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransferTo.Font = new Font("Segoe UI", 10F);
            comboBoxTransferTo.Location = new Point(13, 38);
            comboBoxTransferTo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTransferTo.Name = "comboBoxTransferTo";
            comboBoxTransferTo.Size = new Size(193, 25);
            comboBoxTransferTo.TabIndex = 1;
            // 
            // labelTransferAmount
            // 
            labelTransferAmount.AutoSize = true;
            labelTransferAmount.Font = new Font("Segoe UI", 9F);
            labelTransferAmount.Location = new Point(13, 80);
            labelTransferAmount.Name = "labelTransferAmount";
            labelTransferAmount.Size = new Size(56, 15);
            labelTransferAmount.TabIndex = 2;
            labelTransferAmount.Text = "Сума (₴):";
            // 
            // textBoxTransferAmount
            // 
            textBoxTransferAmount.Font = new Font("Segoe UI", 10F);
            textBoxTransferAmount.Location = new Point(13, 97);
            textBoxTransferAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxTransferAmount.Name = "textBoxTransferAmount";
            textBoxTransferAmount.Size = new Size(193, 25);
            textBoxTransferAmount.TabIndex = 3;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.FromArgb(52, 152, 219);
            btnTransfer.Cursor = Cursors.Hand;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(228, 38);
            btnTransfer.Margin = new Padding(3, 2, 3, 2);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(104, 83);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Переказати";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // groupBoxDeposit
            // 
            groupBoxDeposit.Controls.Add(labelDepositAmount);
            groupBoxDeposit.Controls.Add(textBoxDepositAmount);
            groupBoxDeposit.Controls.Add(btnDeposit);
            groupBoxDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDeposit.Location = new Point(10, 540);
            groupBoxDeposit.Name = "groupBoxDeposit";
            groupBoxDeposit.Size = new Size(329, 142);
            groupBoxDeposit.TabIndex = 2;
            groupBoxDeposit.TabStop = false;
            groupBoxDeposit.Text = "Поповнити обрану ціль";
            // 
            // labelDepositAmount
            // 
            labelDepositAmount.AutoSize = true;
            labelDepositAmount.Font = new Font("Segoe UI", 9F);
            labelDepositAmount.Location = new Point(15, 28);
            labelDepositAmount.Name = "labelDepositAmount";
            labelDepositAmount.Size = new Size(56, 15);
            labelDepositAmount.TabIndex = 0;
            labelDepositAmount.Text = "Сума (₴):";
            // 
            // textBoxDepositAmount
            // 
            textBoxDepositAmount.Font = new Font("Segoe UI", 10F);
            textBoxDepositAmount.Location = new Point(15, 46);
            textBoxDepositAmount.Multiline = true;
            textBoxDepositAmount.Name = "textBoxDepositAmount";
            textBoxDepositAmount.Size = new Size(133, 80);
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
            btnDeposit.Location = new Point(172, 46);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(133, 80);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Відкласти в тумбочку";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnDeleteSavingsGoal
            // 
            btnDeleteSavingsGoal.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteSavingsGoal.Cursor = Cursors.Hand;
            btnDeleteSavingsGoal.FlatAppearance.BorderSize = 0;
            btnDeleteSavingsGoal.FlatStyle = FlatStyle.Flat;
            btnDeleteSavingsGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteSavingsGoal.ForeColor = Color.White;
            btnDeleteSavingsGoal.Location = new Point(905, 549);
            btnDeleteSavingsGoal.Name = "btnDeleteSavingsGoal";
            btnDeleteSavingsGoal.Size = new Size(173, 133);
            btnDeleteSavingsGoal.TabIndex = 3;
            btnDeleteSavingsGoal.Text = "Видалити ціль";
            btnDeleteSavingsGoal.UseVisualStyleBackColor = false;
            btnDeleteSavingsGoal.Click += btnDeleteSavingsGoal_Click;
            // 
            // tabPageBudget
            // 
            tabPageBudget.Controls.Add(groupBoxAddBudget);
            tabPageBudget.Controls.Add(dataGridViewBudget);
            tabPageBudget.Controls.Add(btnDeleteBudgetLimit);
            tabPageBudget.Controls.Add(btnGenerateReport);
            tabPageBudget.Location = new Point(4, 40);
            tabPageBudget.Name = "tabPageBudget";
            tabPageBudget.Padding = new Padding(10, 10, 10, 10);
            tabPageBudget.Size = new Size(1092, 695);
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
            groupBoxAddBudget.Location = new Point(10, 10);
            groupBoxAddBudget.Name = "groupBoxAddBudget";
            groupBoxAddBudget.Size = new Size(1068, 120);
            groupBoxAddBudget.TabIndex = 0;
            groupBoxAddBudget.TabStop = false;
            groupBoxAddBudget.Text = "Встановити місячний ліміт";
            // 
            // labelBudgetCategory
            // 
            labelBudgetCategory.AutoSize = true;
            labelBudgetCategory.Font = new Font("Segoe UI", 9F);
            labelBudgetCategory.Location = new Point(15, 30);
            labelBudgetCategory.Name = "labelBudgetCategory";
            labelBudgetCategory.Size = new Size(62, 15);
            labelBudgetCategory.TabIndex = 0;
            labelBudgetCategory.Text = "Категорія:";
            // 
            // comboBoxBudgetCategory
            // 
            comboBoxBudgetCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBudgetCategory.Font = new Font("Segoe UI", 10F);
            comboBoxBudgetCategory.Location = new Point(15, 50);
            comboBoxBudgetCategory.Name = "comboBoxBudgetCategory";
            comboBoxBudgetCategory.Size = new Size(221, 25);
            comboBoxBudgetCategory.TabIndex = 1;
            // 
            // labelBudgetLimit
            // 
            labelBudgetLimit.AutoSize = true;
            labelBudgetLimit.Font = new Font("Segoe UI", 9F);
            labelBudgetLimit.Location = new Point(250, 30);
            labelBudgetLimit.Name = "labelBudgetLimit";
            labelBudgetLimit.Size = new Size(111, 15);
            labelBudgetLimit.TabIndex = 2;
            labelBudgetLimit.Text = "Ліміт на місяць (₴):";
            // 
            // textBoxBudgetLimit
            // 
            textBoxBudgetLimit.Font = new Font("Segoe UI", 10F);
            textBoxBudgetLimit.Location = new Point(250, 50);
            textBoxBudgetLimit.Name = "textBoxBudgetLimit";
            textBoxBudgetLimit.Size = new Size(160, 25);
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
            btnAddBudgetLimit.Location = new Point(430, 46);
            btnAddBudgetLimit.Name = "btnAddBudgetLimit";
            btnAddBudgetLimit.Size = new Size(623, 32);
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
            dataGridViewBudget.Location = new Point(10, 140);
            dataGridViewBudget.Name = "dataGridViewBudget";
            dataGridViewBudget.ReadOnly = true;
            dataGridViewBudget.RowHeadersVisible = false;
            dataGridViewBudget.RowHeadersWidth = 51;
            dataGridViewBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudget.Size = new Size(1068, 390);
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
            btnDeleteBudgetLimit.Location = new Point(878, 551);
            btnDeleteBudgetLimit.Name = "btnDeleteBudgetLimit";
            btnDeleteBudgetLimit.Size = new Size(200, 131);
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
            btnGenerateReport.Location = new Point(657, 551);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(200, 131);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Згенерувати PDF звіт";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // WealthTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 739);
            Controls.Add(tabControlMain);
            MinimumSize = new Size(1116, 737);
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
            groupBoxTransfer.ResumeLayout(false);
            groupBoxTransfer.PerformLayout();
            groupBoxDeposit.ResumeLayout(false);
            groupBoxDeposit.PerformLayout();
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
        private CheckBox checkBoxRecurring;
        private NumericUpDown numericRecurringDay;
        private Label labelRecurringDay;
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
        private Chart chartSavings;
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
        private GroupBox groupBoxTransfer;
        private Label labelTransferTo;
        private ComboBox comboBoxTransferTo;
        private Label labelTransferAmount;
        private TextBox textBoxTransferAmount;
        private Button btnTransfer;
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