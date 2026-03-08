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
            tabControlMain.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            panelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWallet).BeginInit();
            groupBoxAddTransaction.SuspendLayout();
            tabPageTransactions.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageDashboard);
            tabControlMain.Controls.Add(tabPageTransactions);
            tabControlMain.Controls.Add(tabPageAnalytics);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10F);
            tabControlMain.ItemSize = new Size(160, 36);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(4, 3, 4, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(933, 669);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(panelStatistics);
            tabPageDashboard.Controls.Add(pictureBoxWallet);
            tabPageDashboard.Controls.Add(groupBoxAddTransaction);
            tabPageDashboard.Location = new Point(4, 40);
            tabPageDashboard.Margin = new Padding(4, 3, 4, 3);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(10);
            tabPageDashboard.Size = new Size(925, 625);
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
            panelStatistics.Location = new Point(10, 13);
            panelStatistics.Margin = new Padding(4, 3, 4, 3);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(901, 137);
            panelStatistics.TabIndex = 0;
            // 
            // labelBalance
            // 
            labelBalance.BackColor = Color.White;
            labelBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelBalance.ForeColor = Color.FromArgb(44, 62, 80);
            labelBalance.Location = new Point(9, 10);
            labelBalance.Margin = new Padding(4, 0, 4, 0);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(216, 112);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Баланс\n0.00 ₴";
            labelBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.BackColor = Color.White;
            labelTotalIncome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalIncome.ForeColor = Color.FromArgb(44, 62, 80);
            labelTotalIncome.Location = new Point(231, 10);
            labelTotalIncome.Margin = new Padding(4, 0, 4, 0);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(216, 112);
            labelTotalIncome.TabIndex = 1;
            labelTotalIncome.Text = "Доходи\n0.00 ₴";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalExpenses
            // 
            labelTotalExpenses.BackColor = Color.White;
            labelTotalExpenses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalExpenses.ForeColor = Color.FromArgb(44, 62, 80);
            labelTotalExpenses.Location = new Point(453, 10);
            labelTotalExpenses.Margin = new Padding(4, 0, 4, 0);
            labelTotalExpenses.Name = "labelTotalExpenses";
            labelTotalExpenses.Size = new Size(216, 112);
            labelTotalExpenses.TabIndex = 2;
            labelTotalExpenses.Text = "Витрати\n0.00 ₴";
            labelTotalExpenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTransactionCount
            // 
            labelTransactionCount.BackColor = Color.White;
            labelTransactionCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTransactionCount.ForeColor = Color.FromArgb(44, 62, 80);
            labelTransactionCount.Location = new Point(674, 10);
            labelTransactionCount.Margin = new Padding(4, 0, 4, 0);
            labelTransactionCount.Name = "labelTransactionCount";
            labelTransactionCount.Size = new Size(216, 112);
            labelTransactionCount.TabIndex = 3;
            labelTransactionCount.Text = "Транзакцій: 0";
            labelTransactionCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWallet
            // 
            pictureBoxWallet.BackColor = Color.White;
            pictureBoxWallet.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxWallet.Location = new Point(10, 157);
            pictureBoxWallet.Margin = new Padding(4, 3, 4, 3);
            pictureBoxWallet.Name = "pictureBoxWallet";
            pictureBoxWallet.Size = new Size(245, 230);
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
            groupBoxAddTransaction.Controls.Add(btnAddTransaction);
            groupBoxAddTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddTransaction.Location = new Point(268, 157);
            groupBoxAddTransaction.Margin = new Padding(4, 3, 4, 3);
            groupBoxAddTransaction.Name = "groupBoxAddTransaction";
            groupBoxAddTransaction.Padding = new Padding(4, 3, 4, 3);
            groupBoxAddTransaction.Size = new Size(642, 231);
            groupBoxAddTransaction.TabIndex = 2;
            groupBoxAddTransaction.TabStop = false;
            groupBoxAddTransaction.Text = "Додати транзакцію";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F);
            labelType.Location = new Point(15, 30);
            labelType.Margin = new Padding(4, 0, 4, 0);
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
            radioButtonExpense.Margin = new Padding(4, 3, 4, 3);
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
            radioButtonIncome.Margin = new Padding(4, 3, 4, 3);
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
            labelCategory.Location = new Point(15, 85);
            labelCategory.Margin = new Padding(4, 0, 4, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(62, 15);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "Категорія:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(15, 106);
            comboBoxCategory.Margin = new Padding(4, 3, 4, 3);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(221, 25);
            comboBoxCategory.TabIndex = 4;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F);
            labelAmount.Location = new Point(251, 85);
            labelAmount.Margin = new Padding(4, 0, 4, 0);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(56, 15);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Сума (₴):";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 10F);
            textBoxAmount.Location = new Point(251, 106);
            textBoxAmount.Margin = new Padding(4, 3, 4, 3);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(151, 25);
            textBoxAmount.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F);
            labelDate.Location = new Point(418, 85);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(35, 15);
            labelDate.TabIndex = 7;
            labelDate.Text = "Дата:";
            // 
            // dateTimePickerTransaction
            // 
            dateTimePickerTransaction.Font = new Font("Segoe UI", 10F);
            dateTimePickerTransaction.Format = DateTimePickerFormat.Short;
            dateTimePickerTransaction.Location = new Point(418, 106);
            dateTimePickerTransaction.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            dateTimePickerTransaction.Size = new Size(151, 25);
            dateTimePickerTransaction.TabIndex = 8;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.BackColor = Color.FromArgb(46, 204, 113);
            btnAddTransaction.Cursor = Cursors.Hand;
            btnAddTransaction.FlatAppearance.BorderSize = 0;
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTransaction.ForeColor = Color.White;
            btnAddTransaction.Location = new Point(15, 167);
            btnAddTransaction.Margin = new Padding(4, 3, 4, 3);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(607, 44);
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
            tabPageTransactions.Margin = new Padding(4, 3, 4, 3);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Padding = new Padding(10);
            tabPageTransactions.Size = new Size(925, 625);
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
            panelFilter.Margin = new Padding(4, 3, 4, 3);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(901, 55);
            panelFilter.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(849, 14);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(28, 19);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "🔍";
            labelSearch.Click += labelSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(662, 12);
            textBoxSearch.Margin = new Padding(4, 3, 4, 3);
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
            checkBoxFilterDate.Margin = new Padding(4, 3, 4, 3);
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
            dateTimePickerStart.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(116, 23);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Segoe UI", 9F);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(245, 14);
            dateTimePickerEnd.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(116, 23);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.Location = new Point(10, 77);
            dataGridViewTransactions.Margin = new Padding(4, 3, 4, 3);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.Size = new Size(901, 462);
            dataGridViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            btnDeleteTransaction.Location = new Point(723, 550);
            btnDeleteTransaction.Margin = new Padding(4, 3, 4, 3);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(187, 59);
            btnDeleteTransaction.TabIndex = 2;
            btnDeleteTransaction.Text = "Видалити обране";
            btnDeleteTransaction.UseVisualStyleBackColor = false;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(337, 550);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(152, 59);
            btnExport.TabIndex = 3;
            btnExport.Text = "Експорт (.csv)";
            btnExport.Click += btnExport_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.Location = new Point(498, 550);
            btnSaveXml.Margin = new Padding(4, 3, 4, 3);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(152, 59);
            btnSaveXml.TabIndex = 4;
            btnSaveXml.Text = "Зберегти (.xml)";
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(170, 550);
            btnClearFilter.Margin = new Padding(4, 3, 4, 3);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(152, 59);
            btnClearFilter.TabIndex = 6;
            btnClearFilter.Text = "Очистити фільтр";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(9, 550);
            btnFilter.Margin = new Padding(4, 3, 4, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(152, 59);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Фільтр";
            btnFilter.Click += btnFilter_Click;
            // 
            // tabPageAnalytics
            // 
            tabPageAnalytics.Controls.Add(chartPie);
            tabPageAnalytics.Controls.Add(chartLine);
            tabPageAnalytics.Location = new Point(4, 40);
            tabPageAnalytics.Margin = new Padding(4, 3, 4, 3);
            tabPageAnalytics.Name = "tabPageAnalytics";
            tabPageAnalytics.Padding = new Padding(10);
            tabPageAnalytics.Size = new Size(925, 625);
            tabPageAnalytics.TabIndex = 2;
            tabPageAnalytics.Text = "Аналітика";
            //
            // chartPie
            //
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            chartPie.Location = new Point(10, 10);
            chartPie.Name = "chartPie";
            chartPie.Size = new Size(580, 598);
            chartPie.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            //
            // chartLine
            //
            ((System.ComponentModel.ISupportInitialize)chartLine).BeginInit();
            chartLine.Location = new Point(600, 10);
            chartLine.Name = "chartLine";
            chartLine.Size = new Size(308, 598);
            chartLine.TabIndex = 1;
            ((System.ComponentModel.ISupportInitialize)chartLine).EndInit();
            // 
            // WealthTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 669);
            Controls.Add(tabControlMain);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(949, 708);
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
    }
}