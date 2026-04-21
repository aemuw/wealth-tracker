using wealth_tracker.Models;
using wealth_tracker.Services;

namespace wealth_tracker.Forms
{
    public partial class AdminForm : Form
    {
        private readonly UserService _userService;
        private DataGridView gridUsers;
        private TextBox txtNewUsername, txtNewPassword, txtNewPwd, txtChangeMyPwd;
        private ComboBox cmbRole, cmbParent;
        private Button btnCreate, btnDeactivate, btnChangePassword, btnChangeMyPwd;
        private List<AppUser> _allUsers = new();

        public AdminForm(UserService userService)
        {
            _userService = userService;
            SetupUI();
            _ = LoadUsersAsync();
        }

        private void SetupUI()
        {
            Text = "Адміністрування користувачів";
            ClientSize = new Size(960, 640);
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(800, 500);
            BackColor = Color.FromArgb(245, 246, 250);

            var tabControl = new TabControl { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10F) };
            var tabUsers = new TabPage { Text = "Користувачі" };
            var tabProfile = new TabPage { Text = "Мій профіль" };

            gridUsers = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 300,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                EnableHeadersVisualStyles = false
            };
            gridUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            gridUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridUsers.ColumnHeadersHeight = 36;
            gridUsers.RowTemplate.Height = 30;

            var panelCtrl = new Panel { Height = 52, Dock = DockStyle.Top };

            btnDeactivate = new Button
            {
                Text = "Деактивувати",
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Size = new Size(160, 36),
                Location = new Point(10, 8),
                Cursor = Cursors.Hand
            };
            btnDeactivate.FlatAppearance.BorderSize = 0;
            btnDeactivate.Click += BtnDeactivate_Click;

            txtNewPwd = new TextBox
            {
                PlaceholderText = "Новий пароль...",
                PasswordChar = '*',
                Font = new Font("Segoe UI", 9F),
                Size = new Size(160, 28),
                Location = new Point(180, 12)
            };

            btnChangePassword = new Button
            {
                Text = "Змінити пароль",
                BackColor = Color.FromArgb(243, 156, 18),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Size = new Size(160, 36),
                Location = new Point(350, 8),
                Cursor = Cursors.Hand
            };
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.Click += BtnChangePassword_Click;

            panelCtrl.Controls.AddRange(new Control[] { btnDeactivate, txtNewPwd, btnChangePassword });

            var groupCreate = new GroupBox
            {
                Text = "Новий користувач",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                Height = 130,
                Padding = new Padding(10)
            };

            txtNewUsername = new TextBox { Location = new Point(14, 52), Size = new Size(150, 26), Font = new Font("Segoe UI", 10F) };
            txtNewPassword = new TextBox { Location = new Point(178, 52), Size = new Size(150, 26), Font = new Font("Segoe UI", 10F), PasswordChar = '●' };

            cmbRole = new ComboBox
            {
                Location = new Point(342, 52),
                Size = new Size(120, 26),
                Font = new Font("Segoe UI", 10F),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRole.Items.AddRange(Enum.GetNames(typeof(UserRole)));
            cmbRole.SelectedIndex = 3;

            cmbParent = new ComboBox
            {
                Location = new Point(476, 52),
                Size = new Size(180, 26),
                Font = new Font("Segoe UI", 10F),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            btnCreate = new Button
            {
                Text = "Створити",
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(670, 46),
                Size = new Size(140, 36),
                Cursor = Cursors.Hand
            };
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.Click += BtnCreate_Click;

            groupCreate.Controls.AddRange(new Control[]
            {
                new Label { Text = "Логін:", AutoSize = true, Location = new Point(14, 30), Font = new Font("Segoe UI", 9F) },
                txtNewUsername,
                new Label { Text = "Пароль:", AutoSize = true, Location = new Point(178, 30), Font = new Font("Segoe UI", 9F) },
                txtNewPassword,
                new Label { Text = "Роль:", AutoSize = true, Location = new Point(342, 30), Font = new Font("Segoe UI", 9F) },
                cmbRole,
                new Label { Text = "Батько/Мати:", AutoSize = true, Location = new Point(476, 30), Font = new Font("Segoe UI", 9F) },
                cmbParent,
                btnCreate
            });

            tabUsers.Controls.Add(groupCreate);
            tabUsers.Controls.Add(panelCtrl);
            tabUsers.Controls.Add(gridUsers);

            var panelProfile = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20) };

            panelProfile.Controls.Add(new Label
            {
                Text = $"Логін: {_userService.CurrentUser?.Username}\n" +
                       $"Роль: {_userService.CurrentUser?.Role}\n" +
                       $"Створено: {_userService.CurrentUser?.CreatedAt:dd.MM.yyyy}",
                Font = new Font("Segoe UI", 11F),
                Location = new Point(20, 20),
                AutoSize = true
            });

            panelProfile.Controls.Add(new Label
            {
                Text = "Новий пароль:",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(20, 100),
                AutoSize = true
            });

            txtChangeMyPwd = new TextBox
            {
                Font = new Font("Segoe UI", 10F),
                Location = new Point(20, 122),
                Size = new Size(200, 28),
                PasswordChar = '*'
            };

            btnChangeMyPwd = new Button
            {
                Text = "Зберегти пароль",
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(234, 120),
                Size = new Size(160, 32),
                Cursor = Cursors.Hand
            };
            btnChangeMyPwd.FlatAppearance.BorderSize = 0;
            btnChangeMyPwd.Click += BtnChangeMyPwd_Click;

            panelProfile.Controls.AddRange(new Control[] { txtChangeMyPwd, btnChangeMyPwd });
            tabProfile.Controls.Add(panelProfile);

            tabControl.TabPages.AddRange(new[] { tabUsers, tabProfile });

            var headerLabel = new Label
            {
                Text = $"Адмін-панель  |  {_userService.CurrentUser?.DisplayName}",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Dock = DockStyle.Top,
                Height = 38,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            Controls.Add(tabControl);
            Controls.Add(headerLabel);
        }

        private async Task LoadUsersAsync()
        {
            _allUsers = await _userService.GetAllUsersAsync();

            var display = _allUsers.Select(u => new
            {
                u.Id,
                Логін = u.Username,
                Роль = u.Role.ToString(),
                Батько = _allUsers.FirstOrDefault(p => p.Id == u.ParentId)?.Username ?? "—",
                Статус = u.IsActive ? "Активний" : "Деактивований",
                Створено = u.CreatedAt.ToString("dd.MM.yyyy")
            }).ToList();

            gridUsers.DataSource = display;

            cmbParent.Items.Clear();
            cmbParent.Items.Add("(немає)");
            foreach (var u in _allUsers.Where(u => u.Role is UserRole.Admin or UserRole.Parent && u.IsActive))
                cmbParent.Items.Add(u);
            cmbParent.DisplayMember = "Username";
            cmbParent.SelectedIndex = 0;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUsername.Text) || string.IsNullOrWhiteSpace(txtNewPassword.Text))
            { 
                MessageBox.Show("Введіть логін і пароль", "Помилка"); 
                return; 
            }

            if (!Enum.TryParse<UserRole>(cmbRole.SelectedItem?.ToString(), out var role))
            { 
                MessageBox.Show("Оберіть роль", "Помилка"); 
                return; 
            }

            Guid? parentId = cmbParent.SelectedItem is AppUser p ? p.Id : null;

            try
            {
                await _userService.CreateUserAsync(txtNewUsername.Text.Trim(), txtNewPassword.Text, role, parentId);
                txtNewUsername.Clear(); txtNewPassword.Clear();
                await LoadUsersAsync();
                MessageBox.Show("Користувача створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Помилка"); }
        }

        private async void BtnDeactivate_Click(object? sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count == 0) 
                return;
            if (MessageBox.Show("Деактивувати цього користувача?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) 
                return;
            try
            {
                var id = (Guid)gridUsers.SelectedRows[0].Cells["Id"].Value;
                await _userService.DeactivateUserAsync(id);
                await LoadUsersAsync();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        private async void BtnChangePassword_Click(object? sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count == 0 || string.IsNullOrEmpty(txtNewPwd.Text))
                return;
            try
            {
                var id = (Guid)gridUsers.SelectedRows[0].Cells["Id"].Value;
                await _userService.ChangePasswordAsync(id, txtNewPwd.Text);
                txtNewPwd.Clear();
                MessageBox.Show("Пароль змінено!", "Успіх");
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Помилка"); 
            }
        }

        private async void BtnChangeMyPwd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChangeMyPwd.Text))
                return;
            try
            {
                await _userService.ChangePasswordAsync(_userService.CurrentUser!.Id, txtChangeMyPwd.Text);
                txtChangeMyPwd.Clear();
                MessageBox.Show("Пароль змінено!", "Успіх");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Помилка"); 
            }
        }
    }
}