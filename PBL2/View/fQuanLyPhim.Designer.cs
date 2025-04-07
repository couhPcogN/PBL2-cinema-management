namespace PBL2.View
{
    partial class fQuanLyPhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtDinhDang;
        private System.Windows.Forms.ComboBox comboBoxTheLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPhim = new System.Windows.Forms.DataGridView();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtDinhDang = new System.Windows.Forms.TextBox();
            this.comboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhim
            // 
            this.dataGridViewPhim.ColumnHeadersHeight = 34;
            this.dataGridViewPhim.Location = new System.Drawing.Point(30, 250);
            this.dataGridViewPhim.Name = "dataGridViewPhim";
            this.dataGridViewPhim.RowHeadersWidth = 62;
            this.dataGridViewPhim.Size = new System.Drawing.Size(700, 200);
            this.dataGridViewPhim.TabIndex = 0;
            this.dataGridViewPhim.SelectionChanged += new System.EventHandler(this.dataGridViewPhim_SelectionChanged);
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(150, 30);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(200, 26);
            this.txtTenPhim.TabIndex = 1;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(150, 70);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(200, 26);
            this.txtThoiLuong.TabIndex = 2;
            // 
            // txtDinhDang
            // 
            this.txtDinhDang.Location = new System.Drawing.Point(150, 150);
            this.txtDinhDang.Name = "txtDinhDang";
            this.txtDinhDang.Size = new System.Drawing.Size(200, 26);
            this.txtDinhDang.TabIndex = 3;
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.Location = new System.Drawing.Point(150, 110);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(200, 28);
            this.comboBoxTheLoai.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(400, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(400, 150);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxPoster.Location = new System.Drawing.Point(559, 12);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(229, 232);
            this.pictureBoxPoster.TabIndex = 9;
            this.pictureBoxPoster.TabStop = false;
            // 
            // fQuanLyPhim
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.txtThoiLuong);
            this.Controls.Add(this.txtDinhDang);
            this.Controls.Add(this.comboBoxTheLoai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridViewPhim);
            this.Name = "fQuanLyPhim";
            this.Text = "Quản Lý Phim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBoxPoster;
    }
}
