using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PBL2.View
{
    public partial class fDangNhap : Form
    {
        private Dictionary<string, string> userAccounts;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;

        public fDangNhap()
        {
            InitializeComponent();
            InitializeUserAccounts();
            SetupUI();
        }

        private void InitializeUserAccounts()
        {
            userAccounts = new Dictionary<string, string>
            {
                { "admin", "1234" },
                { "staff", "5678" }
            };
        }

        private void SetupUI()
        {
            this.Text = "Đăng Nhập - Hệ Thống Quản Lý Rạp Phim";
            this.Size = new Size(450, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = Color.FromArgb(240, 240, 240);

            Panel panel = new Panel()
            {
                Size = new Size(400, 300),
                Location = new Point(25, 20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(panel);

            Label lblTitle = new Label()
            {
                Text = "🎬 Đăng Nhập Hệ Thống",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Maroon,
                AutoSize = true,
                Location = new Point(100, 20)
            };
            panel.Controls.Add(lblTitle);

            Label lblUser = new Label()
            {
                Text = "Tên đăng nhập:",
                Location = new Point(50, 70),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            panel.Controls.Add(lblUser);

            txtUser = new TextBox()
            {
                Location = new Point(180, 65),
                Width = 160,
                Font = new Font("Arial", 10)
            };
            panel.Controls.Add(txtUser);

            Label lblPass = new Label()
            {
                Text = "Mật khẩu:",
                Location = new Point(50, 120),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            panel.Controls.Add(lblPass);

            txtPass = new TextBox()
            {
                Location = new Point(180, 115),
                Width = 160,
                Font = new Font("Arial", 10),
                PasswordChar = '*'
            };
            panel.Controls.Add(txtPass);

            CheckBox chkShowPass = new CheckBox()
            {
                Text = "Hiển thị mật khẩu",
                Location = new Point(180, 145),
                AutoSize = true,
                Font = new Font("Arial", 9)
            };
            chkShowPass.CheckedChanged += (s, e) =>
            {
                txtPass.PasswordChar = chkShowPass.Checked ? '\0' : '*';
            };
            panel.Controls.Add(chkShowPass);

            btnLogin = new Button()
            {
                Text = "Đăng Nhập",
                Location = new Point(80, 200),
                Size = new Size(110, 40),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnLogin.Click += (s, e) => Login();
            panel.Controls.Add(btnLogin);

            Button btnExit = new Button()
            {
                Text = "Thoát",
                Location = new Point(220, 200),
                Size = new Size(110, 40),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnExit.Click += (s, e) => Application.Exit();
            panel.Controls.Add(btnExit);
        }

        private void Login()
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (userAccounts.ContainsKey(username) && userAccounts[username] == password)
            {
                MessageBox.Show("🎉 Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                fControl mainForm = new fControl(username);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("❌ Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
        }
    }
}
