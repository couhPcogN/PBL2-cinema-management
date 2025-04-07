using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL2.View
{
    public partial class fControl : Form
    {
        private string currentUser;

        public fControl(string username)
        {
            InitializeComponent();
            currentUser = username;
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Quản Lý Rạp Chiếu Phim";
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;

            Label lblWelcome = new Label()
            {
                Text = $"Xin chào, {currentUser}!",
                Location = new Point(20, 50),
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true
            };
            this.Controls.Add(lblWelcome);

            MenuStrip menuStrip = new MenuStrip()
            {
                Dock = DockStyle.Top,
                BackColor = Color.Maroon,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            this.Controls.Add(menuStrip);

            menuStrip.Items.Add(CreateMenuItem("🎬 Quản Lý Phim", () =>
            {
                fQuanLyPhim formPhim = new fQuanLyPhim();
                formPhim.ShowDialog(); // hoặc Show() nếu không muốn chặn các form khác
            }));

      

            menuStrip.Items.Add(CreateMenuItem("🏢 Phòng Chiếu", () => MessageBox.Show("Chức năng phòng chiếu")));
            menuStrip.Items.Add(CreateMenuItem("🗓 Lịch Chiếu", () => MessageBox.Show("Chức năng lịch chiếu")));
            menuStrip.Items.Add(CreateMenuItem("🏷 Thể loại", () => MessageBox.Show("Chức năng thể loại")));

            menuStrip.Items.Add(CreateMenuItem("👨‍💼 Nhân Viên", () => MessageBox.Show("Chức năng nhân viên")));
            menuStrip.Items.Add(CreateMenuItem("🎟 Vé", () => MessageBox.Show("Chức năng quản lý vé")));
            menuStrip.Items.Add(CreateMenuItem("📊 Thống Kê", () => MessageBox.Show("Chức năng thống kê")));

            Button btnLogout = new Button()
            {
                Text = "Đăng Xuất",
                Location = new Point(1050, 40),
                Size = new Size(120, 40),
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnLogout.Click += (s, e) =>
            {
                this.Hide();
                new fDangNhap().Show();
            };
            this.Controls.Add(btnLogout);
        }

        private ToolStripMenuItem CreateMenuItem(string text, Action onClick)
        {
            var item = new ToolStripMenuItem(text);
            item.Click += (s, e) => onClick();
            return item;
        }
    }
}
