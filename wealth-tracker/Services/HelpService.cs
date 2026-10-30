using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    /// <summary>Local offline help; call Attach once after InitializeComponent.</summary>
    public static class HelpService
    {
        private static readonly ConditionalWeakTable<Form, ToolTip> Attached = new();
        internal static readonly (string Id, string Title)[] Topics =
        {
            ("index", "Початок роботи"), ("login", "Вхід у програму"),
            ("users", "Користувачі та права"), ("transactions", "Доходи та витрати"),
            ("analytics", "Аналітика"), ("savings", "Накопичення"), ("budget", "Бюджет і звіти")
        };
        private static readonly Dictionary<string, string> Tips = new()
        {
            ["textBoxUsername"] = "Введіть логін активного облікового запису. Enter — перехід до пароля.",
            ["textBoxPassword"] = "Введіть пароль із правильним регістром. Enter — вхід. F1 — довідка.",
            ["textBoxAmount"] = "Додатна сума операції у гривнях. Наприклад: 125,50.",
            ["comboBoxCategory"] = "Оберіть категорію для вибраного типу операції: дохід або витрата.",
            ["dateTimePickerTransaction"] = "Дата здійснення операції.",
            ["textBoxNote"] = "Необов’язкова примітка для пошуку й пояснення операції.",
            ["textBoxSearch"] = "Пошук операцій за текстом. Для дат увімкніть відповідний фільтр.",
            ["numericRecurringDay"] = "День місяця для повторюваної операції, від 1 до 31.",
            ["textBoxSavingsName"] = "Введіть назву цілі накопичення.",
            ["textBoxSavingsTarget"] = "Цільова сума: додатне число; для безлімітної цілі залиште поле порожнім.",
            ["textBoxDepositAmount"] = "Додатна сума поповнення вибраної цілі.",
            ["textBoxTransferAmount"] = "Сума переказу між вибраними цілями накопичення.",
            ["comboBoxTransferTo"] = "Оберіть ціль, на яку потрібно переказати кошти.",
            ["textBoxBudgetLimit"] = "Додатна сума місячного ліміту категорії витрат.",
            ["txtNewUsername"] = "Логін нового користувача. Порожні та повторні логіни не допускаються.",
            ["txtNewPassword"] = "Початковий пароль нового облікового запису.",
            ["cmbRole"] = "Роль: Admin, Parent, Child або Member.",
            ["cmbParent"] = "Батьківський обліковий запис або варіант без батьківського зв’язку.",
            ["txtNewPwd"] = "Новий пароль користувача, вибраного у таблиці.",
            ["txtChangeMyPwd"] = "Новий пароль поточного користувача у вкладці «Мій профіль»."
        };

        public static void Attach(Form form, string topic, Func<AppUser?>? currentUser = null, Func<string>? contextTopic = null)
        {
            ArgumentNullException.ThrowIfNull(form);
            if (Attached.TryGetValue(form, out _)) return;
            var tips = new ToolTip { AutoPopDelay = 9000, InitialDelay = 400, ReshowDelay = 100, ShowAlways = true };
            Attached.Add(form, tips);
            string normalized = Normalize(topic);
            string ActiveTopic() => Normalize(contextTopic?.Invoke() ?? normalized);
            Bind(form, tips);
            // Reserve separate layout space: existing absolute and docked controls
            // retain the same content coordinates and available client area.
            Size originalClientSize = form.ClientSize;
            var existing = new Control[form.Controls.Count];
            form.Controls.CopyTo(existing, 0);
            var bounds = new Rectangle[existing.Length];
            for (int i = 0; i < existing.Length; i++) bounds[i] = existing[i].Bounds;
            form.SuspendLayout();
            var contentPanel = new Panel
            {
                Name = "helpContentPanel", Size = originalClientSize,
                Dock = DockStyle.Fill, TabIndex = 0
            };
            contentPanel.SuspendLayout();
            foreach (Control control in existing) contentPanel.Controls.Add(control);
            for (int i = 0; i < existing.Length; i++)
            {
                contentPanel.Controls.SetChildIndex(existing[i], i);
                existing[i].Bounds = bounds[i];
            }
            form.Controls.Add(contentPanel);
            form.KeyPreview = true;
            form.KeyDown += (_, e) =>
            {
                if (e.KeyCode != Keys.F1) return;
                e.Handled = true;
                e.SuppressKeyPress = true;
                Open(form, ActiveTopic());
            };
            form.HelpRequested += (_, e) => { e.Handled = true; Open(form, ActiveTopic()); };

            var menu = new MenuStrip { Name = "helpMenuStrip", Dock = DockStyle.Top };
            var help = new ToolStripMenuItem("&Довідка");
            help.DropDownItems.Add("Довідка цього вікна (F1)", null, (_, _) => Open(form, ActiveTopic()));
            help.DropDownItems.Add("Зміст довідки", null, (_, _) => Open(form, "index"));
            help.DropDownItems.Add("Про WealthTracker", null, (_, _) => MessageBox.Show(form,
                "WealthTracker\nОблік особистих фінансів.\nЛокальна довідка: клавіша F1.\nДоходи, витрати, накопичення та бюджет.",
                "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information));
            menu.Items.Add(help);
            form.Controls.Add(menu);
            form.MainMenuStrip ??= menu;

            int reservedHeight = menu.PreferredSize.Height;
            if (normalized != "login")
            {
                var status = new StatusStrip { Name = "activeUserStatusStrip", Dock = DockStyle.Bottom };
                var userLabel = new ToolStripStatusLabel();
                status.Items.Add(userLabel);
                status.Items.Add(new ToolStripStatusLabel("F1 — довідка") { Spring = true, TextAlign = ContentAlignment.MiddleRight });
                void RefreshUser()
                {
                    var user = currentUser?.Invoke();
                    userLabel.Text = user == null ? "Користувач: не авторизований" : $"Користувач: {user.Username}  |  Роль: {user.Role}";
                }
                RefreshUser();
                form.Activated += (_, _) => RefreshUser();
                form.Controls.Add(status);
                reservedHeight += status.PreferredSize.Height;
            }
            form.ClientSize = new Size(originalClientSize.Width, originalClientSize.Height + reservedHeight);
            form.Controls.SetChildIndex(contentPanel, 0);
            contentPanel.ResumeLayout(true);
            form.ResumeLayout(true);
            form.Disposed += (_, _) => tips.Dispose();
        }

        private static void Bind(Control parent, ToolTip tips)
        {
            foreach (Control child in parent.Controls)
            {
                if (Tips.TryGetValue(child.Name, out string? tip))
                {
                    tips.SetToolTip(child, tip);
                    if (child is TextBoxBase || child is ComboBox || child is NumericUpDown)
                    {
                        child.Enter += (_, _) => tips.Show(tip, child, 0, child.Height + 2, 4500);
                        child.Leave += (_, _) => tips.Hide(child);
                    }
                }
                Bind(child, tips);
            }
        }

        internal static string Normalize(string? topic)
        {
            string id = Path.GetFileNameWithoutExtension(topic ?? "index").ToLowerInvariant();
            foreach (var entry in Topics) if (entry.Id == id) return id;
            return "index";
        }

        public static void Open(Form owner, string topic = "index")
        {
            var window = new HelpForm(Normalize(topic));
            window.Show(owner);
        }
    }

    /// <summary>Native accessible viewer does not require a browser runtime or network.</summary>
    public sealed class HelpForm : Form
    {
        private readonly RichTextBox content;
        private readonly TreeView tree;

        public HelpForm(string topic = "index")
        {
            Text = "Довідка WealthTracker — автономна версія";
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(1000, 680);
            MinimumSize = new Size(760, 460);
            var split = new SplitContainer { Dock = DockStyle.Fill, FixedPanel = FixedPanel.Panel1 };
            split.Size = ClientSize;
            split.SplitterDistance = 240;
            tree = new TreeView { Dock = DockStyle.Fill, HideSelection = false, AccessibleName = "Розділи довідки" };
            content = new RichTextBox
            {
                Dock = DockStyle.Fill, ReadOnly = true, DetectUrls = false,
                BackColor = Color.White, ForeColor = Color.FromArgb(27, 40, 54),
                Font = new Font("Segoe UI", 11), BorderStyle = BorderStyle.None,
                AccessibleName = "Текст довідки"
            };
            split.Panel1.Controls.Add(tree);
            split.Panel2.Controls.Add(content);
            Controls.Add(split);
            foreach (var entry in HelpService.Topics) tree.Nodes.Add(entry.Id, entry.Title);
            tree.AfterSelect += (_, e) => LoadTopic(e.Node?.Name ?? "index");
            tree.SelectedNode = tree.Nodes[HelpService.Normalize(topic)];
            LoadTopic(topic);
            KeyPreview = true;
            KeyDown += (_, e) => { if (e.KeyCode == Keys.Escape) Close(); };
        }

        private void LoadTopic(string topic)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "docs", HelpService.Normalize(topic) + ".txt");
            try
            {
                content.Text = File.ReadAllText(path, Encoding.UTF8);
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                content.Text = "Не вдалося відкрити локальний розділ довідки.\n\n" +
                    "Перевірте наявність папки docs поруч із програмою або повторно встановіть WealthTracker.\n\n" + path;
            }
            content.Select(0, 0);
            content.ScrollToCaret();
        }
    }
}
