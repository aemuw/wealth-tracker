using System;
using System.Drawing;
using System.Windows.Forms;
using wealth_tracker.Services;

namespace wealth_tracker.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button btnLogin;
        private Label labelError;
        private Panel panelMain;

        public LoginForm(UserService userService)
        {
            _userService = userService;
            SetupUI();
        }

        private void SetupUI()
        {
            Text = "Вхід";
            ClientSize = new Size(400, 420);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(236, 240, 241);

            var labelTitle = new Label
            {
                Text = "WealthTracker",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(40, 20),
                Size = new Size(320, 44),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var labelSub = new Label
            {
                Text = "Система управління персональними капіталами",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(127, 140, 141),
                Location = new Point(40, 58),
                Size = new Size(320, 18),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelMain = new Panel
            {
                BackColor = Color.White,
                Location = new Point(40, 86),
                Size = new Size(320, 308)
            };

            var lblUser = new Label
            {
                Text = "Логін:",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(30, 30),
                AutoSize = true
            };

            textBoxUsername = new TextBox
            {
                Font = new Font("Segoe UI", 11F),
                Location = new Point(30, 52),
                Size = new Size(258, 28),
                BorderStyle = BorderStyle.FixedSingle
            };
            textBoxUsername.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) 
                    textBoxPassword.Focus();
            };

            var lblPwd = new Label
            {
                Text = "Пароль:",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(30, 96),
                AutoSize = true
            };

            textBoxPassword = new TextBox
            {
                Font = new Font("Segoe UI", 11F),
                Location = new Point(30, 118),
                Size = new Size(258, 28),
                PasswordChar = '*',
                BorderStyle = BorderStyle.FixedSingle
            };
            textBoxPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) 
                    TryLogin();
            };

            labelError = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(192, 57, 43),
                Location = new Point(30, 158),
                Size = new Size(258, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnLogin = new Button
            {
                Text = "Увійти",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(30, 188),
                Size = new Size(258, 44),
                Cursor = Cursors.Hand
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += (s, e) => TryLogin();

            var labelHint = new Label
            {
                Text = "За замовчуванням: admin / admin123",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(149, 165, 166),
                Location = new Point(30, 246),
                Size = new Size(258, 16),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelMain.Controls.AddRange(new Control[]
            {
                lblUser, textBoxUsername,
                lblPwd, textBoxPassword,
                labelError, btnLogin, labelHint
            });

            Controls.AddRange(new Control[] { labelTitle, labelSub, panelMain });
            ActiveControl = textBoxUsername;
        }
        
        private async void TryLogin()
        {
            labelError.Text = "";
            var username = textBoxUsername.Text.Trim();
            var password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelError.Text = "Введіть логін і пароль";
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Перевірка...";

            var ok = await _userService.LoginAsync(username, password);

            btnLogin.Enabled = true;
            btnLogin.Text = "Увійти";

            if (ok)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                labelError.Text = "Невірний логін або пароль";
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
        }
    }
}
