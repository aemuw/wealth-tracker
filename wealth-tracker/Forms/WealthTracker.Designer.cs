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
            groupBox1 = new GroupBox();
            btnDeleteSavingsGoal = new Button();
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
            groupBoxTransfer = new GroupBox();
            labelTransferTo = new Label();
            comboBoxTransferTo = new ComboBox();
            labelTransferAmount = new Label();
            textBoxTransferAmount = new TextBox();
            btnTransfer = new Button();
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
            groupBox1.SuspendLayout();
            groupBoxAddSavings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).BeginInit();
            groupBoxDeposit.SuspendLayout();
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
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1257, 960);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(panelStatistics);
            tabPageDashboard.Controls.Add(pictureBoxWallet);
            tabPageDashboard.Controls.Add(groupBoxAddTransaction);
            tabPageDashboard.Location = new Point(4, 40);
            tabPageDashboard.Margin = new Padding(3, 4, 3, 4);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(11);
            tabPageDashboard.Size = new Size(1249, 916);
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
            panelStatistics.Location = new Point(11, 11);
            panelStatistics.Margin = new Padding(3, 4, 3, 4);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(1221, 147);
            panelStatistics.TabIndex = 0;
            // 
            // labelBalance
            // 
            labelBalance.BackColor = Color.White;
            labelBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelBalance.ForeColor = Color.FromArgb(44, 62, 80);
            labelBalance.Location = new Point(7, 11);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(226, 120);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Баланс\n0.00 ₴";
            labelBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.BackColor = Color.White;
            labelTotalIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalIncome.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalIncome.Location = new Point(245, 11);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(226, 120);
            labelTotalIncome.TabIndex = 1;
            labelTotalIncome.Text = "Доходи\n0.00 ₴";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalExpenses
            // 
            labelTotalExpenses.BackColor = Color.White;
            labelTotalExpenses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalExpenses.ForeColor = Color.FromArgb(192, 57, 43);
            labelTotalExpenses.Location = new Point(482, 11);
            labelTotalExpenses.Name = "labelTotalExpenses";
            labelTotalExpenses.Size = new Size(226, 120);
            labelTotalExpenses.TabIndex = 2;
            labelTotalExpenses.Text = "Витрати\n0.00 ₴";
            labelTotalExpenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTransactionCount
            // 
            labelTransactionCount.BackColor = Color.White;
            labelTransactionCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTransactionCount.ForeColor = Color.FromArgb(44, 62, 80);
            labelTransactionCount.Location = new Point(720, 11);
            labelTransactionCount.Name = "labelTransactionCount";
            labelTransactionCount.Size = new Size(226, 120);
            labelTransactionCount.TabIndex = 3;
            labelTransactionCount.Text = "Транзакцій: 0";
            labelTransactionCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelForecast
            // 
            labelForecast.BackColor = Color.FromArgb(214, 234, 248);
            labelForecast.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelForecast.ForeColor = Color.FromArgb(44, 62, 80);
            labelForecast.Location = new Point(958, 11);
            labelForecast.Name = "labelForecast";
            labelForecast.Size = new Size(256, 120);
            labelForecast.TabIndex = 4;
            labelForecast.Text = "Прогноз на кінець місяця\n0.00 ₴";
            labelForecast.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWallet
            // 
            pictureBoxWallet.BackColor = Color.White;
            pictureBoxWallet.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxWallet.Location = new Point(11, 168);
            pictureBoxWallet.Margin = new Padding(3, 4, 3, 4);
            pictureBoxWallet.Name = "pictureBoxWallet";
            pictureBoxWallet.Size = new Size(274, 319);
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
            groupBoxAddTransaction.Location = new Point(297, 168);
            groupBoxAddTransaction.Margin = new Padding(3, 4, 3, 4);
            groupBoxAddTransaction.Name = "groupBoxAddTransaction";
            groupBoxAddTransaction.Padding = new Padding(3, 4, 3, 4);
            groupBoxAddTransaction.Size = new Size(935, 320);
            groupBoxAddTransaction.TabIndex = 2;
            groupBoxAddTransaction.TabStop = false;
            groupBoxAddTransaction.Text = "Додати транзакцію";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F);
            labelType.Location = new Point(16, 35);
            labelType.Name = "labelType";
            labelType.Size = new Size(113, 20);
            labelType.TabIndex = 0;
            labelType.Text = "Тип транзакції:";
            // 
            // radioButtonExpense
            // 
            radioButtonExpense.AutoSize = true;
            radioButtonExpense.Checked = true;
            radioButtonExpense.Font = new Font("Segoe UI", 9F);
            radioButtonExpense.Location = new Point(16, 61);
            radioButtonExpense.Margin = new Padding(3, 4, 3, 4);
            radioButtonExpense.Name = "radioButtonExpense";
            radioButtonExpense.Size = new Size(85, 24);
            radioButtonExpense.TabIndex = 1;
            radioButtonExpense.TabStop = true;
            radioButtonExpense.Text = "Витрата";
            radioButtonExpense.CheckedChanged += radioButtonExpense_CheckedChanged;
            // 
            // radioButtonIncome
            // 
            radioButtonIncome.AutoSize = true;
            radioButtonIncome.Font = new Font("Segoe UI", 9F);
            radioButtonIncome.Location = new Point(149, 61);
            radioButtonIncome.Margin = new Padding(3, 4, 3, 4);
            radioButtonIncome.Name = "radioButtonIncome";
            radioButtonIncome.Size = new Size(68, 24);
            radioButtonIncome.TabIndex = 2;
            radioButtonIncome.Text = "Дохід";
            radioButtonIncome.CheckedChanged += radioButtonIncome_CheckedChanged;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 9F);
            labelCategory.Location = new Point(16, 104);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(79, 20);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "Категорія:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(16, 128);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(239, 31);
            comboBoxCategory.TabIndex = 4;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F);
            labelAmount.Location = new Point(16, 176);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(69, 20);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Сума (₴):";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 10F);
            textBoxAmount.Location = new Point(16, 200);
            textBoxAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(239, 30);
            textBoxAmount.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(274, 35);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(44, 20);
            labelDate.TabIndex = 7;
            labelDate.Text = "Дата:";
            // 
            // dateTimePickerTransaction
            // 
            dateTimePickerTransaction.Font = new Font("Segoe UI", 10F);
            dateTimePickerTransaction.Format = DateTimePickerFormat.Short;
            dateTimePickerTransaction.Location = new Point(274, 59);
            dateTimePickerTransaction.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            dateTimePickerTransaction.Size = new Size(182, 30);
            dateTimePickerTransaction.TabIndex = 8;
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Font = new Font("Segoe UI", 9F);
            labelNote.Location = new Point(480, 24);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(67, 20);
            labelNote.TabIndex = 9;
            labelNote.Text = "Нотатка:";
            // 
            // textBoxNote
            // 
            textBoxNote.Font = new Font("Segoe UI", 10F);
            textBoxNote.Location = new Point(480, 48);
            textBoxNote.Margin = new Padding(3, 4, 3, 4);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(436, 201);
            textBoxNote.TabIndex = 10;
            // 
            // checkBoxRecurring
            // 
            checkBoxRecurring.AutoSize = true;
            checkBoxRecurring.Font = new Font("Segoe UI", 9F);
            checkBoxRecurring.Location = new Point(274, 200);
            checkBoxRecurring.Margin = new Padding(3, 4, 3, 4);
            checkBoxRecurring.Name = "checkBoxRecurring";
            checkBoxRecurring.Size = new Size(128, 24);
            checkBoxRecurring.TabIndex = 11;
            checkBoxRecurring.Text = "Повторювана";
            checkBoxRecurring.CheckedChanged += checkBoxRecurring_CheckedChanged;
            // 
            // labelRecurringDay
            // 
            labelRecurringDay.AutoSize = true;
            labelRecurringDay.Font = new Font("Segoe UI", 9F);
            labelRecurringDay.Location = new Point(274, 104);
            labelRecurringDay.Name = "labelRecurringDay";
            labelRecurringDay.Size = new Size(98, 20);
            labelRecurringDay.TabIndex = 12;
            labelRecurringDay.Text = "День місяця:";
            labelRecurringDay.Visible = false;
            // 
            // numericRecurringDay
            // 
            numericRecurringDay.Font = new Font("Segoe UI", 10F);
            numericRecurringDay.Location = new Point(274, 128);
            numericRecurringDay.Margin = new Padding(3, 4, 3, 4);
            numericRecurringDay.Maximum = new decimal(new int[] { 28, 0, 0, 0 });
            numericRecurringDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRecurringDay.Name = "numericRecurringDay";
            numericRecurringDay.Size = new Size(183, 30);
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
            btnAddTransaction.Location = new Point(16, 261);
            btnAddTransaction.Margin = new Padding(3, 4, 3, 4);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(903, 48);
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
            tabPageTransactions.Margin = new Padding(3, 4, 3, 4);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Padding = new Padding(11);
            tabPageTransactions.Size = new Size(1249, 916);
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
            panelFilter.Location = new Point(11, 11);
            panelFilter.Margin = new Padding(3, 4, 3, 4);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1221, 59);
            panelFilter.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(1189, 16);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(0, 23);
            labelSearch.TabIndex = 0;
            labelSearch.Click += labelSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(960, 13);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(205, 30);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // checkBoxFilterDate
            // 
            checkBoxFilterDate.AutoSize = true;
            checkBoxFilterDate.Font = new Font("Segoe UI", 9F);
            checkBoxFilterDate.Location = new Point(14, 16);
            checkBoxFilterDate.Margin = new Padding(3, 4, 3, 4);
            checkBoxFilterDate.Name = "checkBoxFilterDate";
            checkBoxFilterDate.Size = new Size(97, 24);
            checkBoxFilterDate.TabIndex = 2;
            checkBoxFilterDate.Text = "За датою:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 9F);
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(123, 13);
            dateTimePickerStart.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(132, 27);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Segoe UI", 9F);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(270, 13);
            dateTimePickerEnd.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(132, 27);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.ColumnHeadersHeight = 29;
            dataGridViewTransactions.Location = new Point(11, 80);
            dataGridViewTransactions.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(1221, 669);
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
            btnDeleteTransaction.Location = new Point(1006, 832);
            btnDeleteTransaction.Margin = new Padding(3, 4, 3, 4);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(226, 59);
            btnDeleteTransaction.TabIndex = 2;
            btnDeleteTransaction.Text = "Видалити обране";
            btnDeleteTransaction.UseVisualStyleBackColor = false;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(350, 832);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(160, 59);
            btnExport.TabIndex = 3;
            btnExport.Text = "Експорт (.csv)";
            btnExport.Click += btnExport_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.Location = new Point(519, 832);
            btnSaveXml.Margin = new Padding(3, 4, 3, 4);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(160, 59);
            btnSaveXml.TabIndex = 4;
            btnSaveXml.Text = "Зберегти (.xml)";
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(181, 832);
            btnClearFilter.Margin = new Padding(3, 4, 3, 4);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(160, 59);
            btnClearFilter.TabIndex = 5;
            btnClearFilter.Text = "Очистити фільтр";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(11, 832);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(160, 59);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;
            // 
            // tabPageAnalytics
            // 
            tabPageAnalytics.Location = new Point(4, 40);
            tabPageAnalytics.Margin = new Padding(3, 4, 3, 4);
            tabPageAnalytics.Name = "tabPageAnalytics";
            tabPageAnalytics.Padding = new Padding(11);
            tabPageAnalytics.Size = new Size(1249, 916);
            tabPageAnalytics.TabIndex = 2;
            tabPageAnalytics.Text = "Аналітика";
            // 
            // tabPageSavings
            // 
            tabPageSavings.Controls.Add(groupBox1);
            tabPageSavings.Controls.Add(groupBoxAddSavings);
            tabPageSavings.Controls.Add(dataGridViewSavings);
            tabPageSavings.Controls.Add(groupBoxDeposit);
            tabPageSavings.Controls.Add(groupBoxTransfer);
            tabPageSavings.Location = new Point(4, 40);
            tabPageSavings.Margin = new Padding(3, 4, 3, 4);
            tabPageSavings.Name = "tabPageSavings";
            tabPageSavings.Padding = new Padding(11);
            tabPageSavings.Size = new Size(1249, 916);
            tabPageSavings.TabIndex = 3;
            tabPageSavings.Text = "Тумбочка";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteSavingsGoal);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(429, 729);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(366, 172);
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
            btnDeleteSavingsGoal.Location = new Point(70, 51);
            btnDeleteSavingsGoal.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSavingsGoal.Name = "btnDeleteSavingsGoal";
            btnDeleteSavingsGoal.Size = new Size(222, 101);
            btnDeleteSavingsGoal.TabIndex = 3;
            btnDeleteSavingsGoal.Text = "Видалити ціль";
            btnDeleteSavingsGoal.UseVisualStyleBackColor = false;
            btnDeleteSavingsGoal.Click += btnDeleteSavingsGoal_Click;
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
            groupBoxAddSavings.Location = new Point(11, 11);
            groupBoxAddSavings.Margin = new Padding(3, 4, 3, 4);
            groupBoxAddSavings.Name = "groupBoxAddSavings";
            groupBoxAddSavings.Padding = new Padding(3, 4, 3, 4);
            groupBoxAddSavings.Size = new Size(1221, 128);
            groupBoxAddSavings.TabIndex = 0;
            groupBoxAddSavings.TabStop = false;
            groupBoxAddSavings.Text = "Нова ціль заощадження";
            // 
            // labelSavingsName
            // 
            labelSavingsName.AutoSize = true;
            labelSavingsName.Font = new Font("Segoe UI", 9F);
            labelSavingsName.Location = new Point(16, 32);
            labelSavingsName.Name = "labelSavingsName";
            labelSavingsName.Size = new Size(54, 20);
            labelSavingsName.TabIndex = 0;
            labelSavingsName.Text = "Назва:";
            // 
            // textBoxSavingsName
            // 
            textBoxSavingsName.Font = new Font("Segoe UI", 10F);
            textBoxSavingsName.Location = new Point(16, 56);
            textBoxSavingsName.Margin = new Padding(3, 4, 3, 4);
            textBoxSavingsName.Name = "textBoxSavingsName";
            textBoxSavingsName.Size = new Size(228, 30);
            textBoxSavingsName.TabIndex = 1;
            // 
            // labelSavingsTarget
            // 
            labelSavingsTarget.AutoSize = true;
            labelSavingsTarget.Font = new Font("Segoe UI", 9F);
            labelSavingsTarget.Location = new Point(261, 32);
            labelSavingsTarget.Name = "labelSavingsTarget";
            labelSavingsTarget.Size = new Size(98, 20);
            labelSavingsTarget.TabIndex = 2;
            labelSavingsTarget.Text = "Сума цілі (₴):";
            // 
            // textBoxSavingsTarget
            // 
            textBoxSavingsTarget.Font = new Font("Segoe UI", 10F);
            textBoxSavingsTarget.Location = new Point(261, 56);
            textBoxSavingsTarget.Margin = new Padding(3, 4, 3, 4);
            textBoxSavingsTarget.Name = "textBoxSavingsTarget";
            textBoxSavingsTarget.Size = new Size(169, 30);
            textBoxSavingsTarget.TabIndex = 3;
            // 
            // labelSavingsDeadline
            // 
            labelSavingsDeadline.AutoSize = true;
            labelSavingsDeadline.Font = new Font("Segoe UI", 9F);
            labelSavingsDeadline.Location = new Point(446, 32);
            labelSavingsDeadline.Name = "labelSavingsDeadline";
            labelSavingsDeadline.Size = new Size(72, 20);
            labelSavingsDeadline.TabIndex = 4;
            labelSavingsDeadline.Text = "Дедлайн:";
            // 
            // dateTimePickerSavingsDeadline
            // 
            dateTimePickerSavingsDeadline.Font = new Font("Segoe UI", 10F);
            dateTimePickerSavingsDeadline.Format = DateTimePickerFormat.Short;
            dateTimePickerSavingsDeadline.Location = new Point(446, 56);
            dateTimePickerSavingsDeadline.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerSavingsDeadline.MinDate = new DateTime(2026, 4, 3, 10, 31, 50, 359);
            dateTimePickerSavingsDeadline.Name = "dateTimePickerSavingsDeadline";
            dateTimePickerSavingsDeadline.Size = new Size(169, 30);
            dateTimePickerSavingsDeadline.TabIndex = 5;
            dateTimePickerSavingsDeadline.Value = new DateTime(2026, 10, 1, 10, 31, 50, 360);
            // 
            // labelSavingsNote
            // 
            labelSavingsNote.AutoSize = true;
            labelSavingsNote.Font = new Font("Segoe UI", 9F);
            labelSavingsNote.Location = new Point(631, 32);
            labelSavingsNote.Name = "labelSavingsNote";
            labelSavingsNote.Size = new Size(184, 20);
            labelSavingsNote.TabIndex = 6;
            labelSavingsNote.Text = "Нотатка (необов'язково):";
            // 
            // textBoxSavingsNote
            // 
            textBoxSavingsNote.Font = new Font("Segoe UI", 10F);
            textBoxSavingsNote.Location = new Point(631, 56);
            textBoxSavingsNote.Margin = new Padding(3, 4, 3, 4);
            textBoxSavingsNote.Name = "textBoxSavingsNote";
            textBoxSavingsNote.Size = new Size(342, 30);
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
            btnAddSavingsGoal.Location = new Point(990, 48);
            btnAddSavingsGoal.Margin = new Padding(3, 4, 3, 4);
            btnAddSavingsGoal.Name = "btnAddSavingsGoal";
            btnAddSavingsGoal.Size = new Size(217, 45);
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
            dataGridViewSavings.Location = new Point(11, 149);
            dataGridViewSavings.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSavings.Name = "dataGridViewSavings";
            dataGridViewSavings.ReadOnly = true;
            dataGridViewSavings.RowHeadersVisible = false;
            dataGridViewSavings.RowHeadersWidth = 51;
            dataGridViewSavings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSavings.Size = new Size(1221, 373);
            dataGridViewSavings.TabIndex = 1;
            // 
            // groupBoxDeposit
            // 
            groupBoxDeposit.Controls.Add(labelDepositAmount);
            groupBoxDeposit.Controls.Add(textBoxDepositAmount);
            groupBoxDeposit.Controls.Add(btnDeposit);
            groupBoxDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDeposit.Location = new Point(11, 729);
            groupBoxDeposit.Margin = new Padding(3, 4, 3, 4);
            groupBoxDeposit.Name = "groupBoxDeposit";
            groupBoxDeposit.Padding = new Padding(3, 4, 3, 4);
            groupBoxDeposit.Size = new Size(366, 172);
            groupBoxDeposit.TabIndex = 2;
            groupBoxDeposit.TabStop = false;
            groupBoxDeposit.Text = "Поповнити обрану ціль";
            // 
            // labelDepositAmount
            // 
            labelDepositAmount.AutoSize = true;
            labelDepositAmount.Font = new Font("Segoe UI", 9F);
            labelDepositAmount.Location = new Point(16, 32);
            labelDepositAmount.Name = "labelDepositAmount";
            labelDepositAmount.Size = new Size(69, 20);
            labelDepositAmount.TabIndex = 0;
            labelDepositAmount.Text = "Сума (₴):";
            // 
            // textBoxDepositAmount
            // 
            textBoxDepositAmount.Font = new Font("Segoe UI", 10F);
            textBoxDepositAmount.Location = new Point(16, 56);
            textBoxDepositAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxDepositAmount.Name = "textBoxDepositAmount";
            textBoxDepositAmount.Size = new Size(148, 30);
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
            btnDeposit.Location = new Point(181, 51);
            btnDeposit.Margin = new Padding(3, 4, 3, 4);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(169, 101);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Відкласти в тумбочку";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // groupBoxTransfer
            // 
            groupBoxTransfer.Controls.Add(labelTransferTo);
            groupBoxTransfer.Controls.Add(comboBoxTransferTo);
            groupBoxTransfer.Controls.Add(labelTransferAmount);
            groupBoxTransfer.Controls.Add(textBoxTransferAmount);
            groupBoxTransfer.Controls.Add(btnTransfer);
            groupBoxTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTransfer.Location = new Point(846, 729);
            groupBoxTransfer.Margin = new Padding(3, 4, 3, 4);
            groupBoxTransfer.Name = "groupBoxTransfer";
            groupBoxTransfer.Padding = new Padding(3, 4, 3, 4);
            groupBoxTransfer.Size = new Size(386, 172);
            groupBoxTransfer.TabIndex = 3;
            groupBoxTransfer.TabStop = false;
            groupBoxTransfer.Text = "Переказ між цілями";
            // 
            // labelTransferTo
            // 
            labelTransferTo.AutoSize = true;
            labelTransferTo.Font = new Font("Segoe UI", 9F);
            labelTransferTo.Location = new Point(11, 32);
            labelTransferTo.Name = "labelTransferTo";
            labelTransferTo.Size = new Size(54, 20);
            labelTransferTo.TabIndex = 0;
            labelTransferTo.Text = "В ціль:";
            // 
            // comboBoxTransferTo
            // 
            comboBoxTransferTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransferTo.Font = new Font("Segoe UI", 10F);
            comboBoxTransferTo.Location = new Point(11, 56);
            comboBoxTransferTo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTransferTo.Name = "comboBoxTransferTo";
            comboBoxTransferTo.Size = new Size(203, 31);
            comboBoxTransferTo.TabIndex = 1;
            // 
            // labelTransferAmount
            // 
            labelTransferAmount.AutoSize = true;
            labelTransferAmount.Font = new Font("Segoe UI", 9F);
            labelTransferAmount.Location = new Point(11, 101);
            labelTransferAmount.Name = "labelTransferAmount";
            labelTransferAmount.Size = new Size(69, 20);
            labelTransferAmount.TabIndex = 2;
            labelTransferAmount.Text = "Сума (₴):";
            // 
            // textBoxTransferAmount
            // 
            textBoxTransferAmount.Font = new Font("Segoe UI", 10F);
            textBoxTransferAmount.Location = new Point(11, 125);
            textBoxTransferAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxTransferAmount.Name = "textBoxTransferAmount";
            textBoxTransferAmount.Size = new Size(203, 30);
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
            btnTransfer.Location = new Point(231, 51);
            btnTransfer.Margin = new Padding(3, 4, 3, 4);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(142, 107);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Переказати";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // tabPageBudget
            // 
            tabPageBudget.Controls.Add(groupBoxAddBudget);
            tabPageBudget.Controls.Add(dataGridViewBudget);
            tabPageBudget.Controls.Add(btnDeleteBudgetLimit);
            tabPageBudget.Controls.Add(btnGenerateReport);
            tabPageBudget.Location = new Point(4, 40);
            tabPageBudget.Margin = new Padding(3, 4, 3, 4);
            tabPageBudget.Name = "tabPageBudget";
            tabPageBudget.Padding = new Padding(11);
            tabPageBudget.Size = new Size(1249, 916);
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
            groupBoxAddBudget.Location = new Point(11, 11);
            groupBoxAddBudget.Margin = new Padding(3, 4, 3, 4);
            groupBoxAddBudget.Name = "groupBoxAddBudget";
            groupBoxAddBudget.Padding = new Padding(3, 4, 3, 4);
            groupBoxAddBudget.Size = new Size(1221, 128);
            groupBoxAddBudget.TabIndex = 0;
            groupBoxAddBudget.TabStop = false;
            groupBoxAddBudget.Text = "Встановити місячний ліміт";
            // 
            // labelBudgetCategory
            // 
            labelBudgetCategory.AutoSize = true;
            labelBudgetCategory.Font = new Font("Segoe UI", 9F);
            labelBudgetCategory.Location = new Point(16, 32);
            labelBudgetCategory.Name = "labelBudgetCategory";
            labelBudgetCategory.Size = new Size(79, 20);
            labelBudgetCategory.TabIndex = 0;
            labelBudgetCategory.Text = "Категорія:";
            // 
            // comboBoxBudgetCategory
            // 
            comboBoxBudgetCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBudgetCategory.Font = new Font("Segoe UI", 10F);
            comboBoxBudgetCategory.Location = new Point(16, 56);
            comboBoxBudgetCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxBudgetCategory.Name = "comboBoxBudgetCategory";
            comboBoxBudgetCategory.Size = new Size(239, 31);
            comboBoxBudgetCategory.TabIndex = 1;
            // 
            // labelBudgetLimit
            // 
            labelBudgetLimit.AutoSize = true;
            labelBudgetLimit.Font = new Font("Segoe UI", 9F);
            labelBudgetLimit.Location = new Point(274, 32);
            labelBudgetLimit.Name = "labelBudgetLimit";
            labelBudgetLimit.Size = new Size(141, 20);
            labelBudgetLimit.TabIndex = 2;
            labelBudgetLimit.Text = "Ліміт на місяць (₴):";
            // 
            // textBoxBudgetLimit
            // 
            textBoxBudgetLimit.Font = new Font("Segoe UI", 10F);
            textBoxBudgetLimit.Location = new Point(274, 56);
            textBoxBudgetLimit.Margin = new Padding(3, 4, 3, 4);
            textBoxBudgetLimit.Name = "textBoxBudgetLimit";
            textBoxBudgetLimit.Size = new Size(182, 30);
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
            btnAddBudgetLimit.Location = new Point(475, 51);
            btnAddBudgetLimit.Margin = new Padding(3, 4, 3, 4);
            btnAddBudgetLimit.Name = "btnAddBudgetLimit";
            btnAddBudgetLimit.Size = new Size(731, 43);
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
            dataGridViewBudget.Location = new Point(11, 149);
            dataGridViewBudget.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBudget.Name = "dataGridViewBudget";
            dataGridViewBudget.ReadOnly = true;
            dataGridViewBudget.RowHeadersVisible = false;
            dataGridViewBudget.RowHeadersWidth = 51;
            dataGridViewBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudget.Size = new Size(1221, 651);
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
            btnDeleteBudgetLimit.Location = new Point(981, 811);
            btnDeleteBudgetLimit.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBudgetLimit.Name = "btnDeleteBudgetLimit";
            btnDeleteBudgetLimit.Size = new Size(251, 80);
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
            btnGenerateReport.Location = new Point(713, 811);
            btnGenerateReport.Margin = new Padding(3, 4, 3, 4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(251, 80);
            btnGenerateReport.TabIndex = 3;
            btnGenerateReport.Text = "Згенерувати PDF звіт";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // WealthTracker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 960);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1273, 995);
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
            groupBox1.ResumeLayout(false);
            groupBoxAddSavings.ResumeLayout(false);
            groupBoxAddSavings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSavings).EndInit();
            groupBoxDeposit.ResumeLayout(false);
            groupBoxDeposit.PerformLayout();
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
        private GroupBox groupBox1;
    }
}
