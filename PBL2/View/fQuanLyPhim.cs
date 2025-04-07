using PBL2.BLL;
using PBL2.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Text;

namespace PBL2.View
{
    public partial class fQuanLyPhim : Form
    {
        public fQuanLyPhim()
        {
            InitializeComponent();
            LoadData();
            LoadTheLoai();
        }

        // Load danh sách phim lên DataGridView
        private void LoadData()
        {
            if (BLL_Phim.Instance.GetAllPhim().Count == 0)
            {
                var danhSachPhim = new List<Phim>
                {
                    new Phim(1, "Nhà Bà Nữ", 110, "Tình Cảm", "2D"),
                    new Phim(2, "Mai", 115, "Tình Cảm", "2D"),
                    new Phim(3, "Bỗng Dưng Trúng Số", 100, "Hài", "2D"),
                    new Phim(4, "Em và Trịnh", 120, "Tình Cảm", "2D"),
                    new Phim(5, "Bẫy Ngọt Ngào", 105, "Tình Cảm", "3D"),
                    new Phim(6, "Chìa Khóa Trăm Tỷ", 110, "Hài", "2D"),
                    new Phim(7, "Nghề Siêu Dễ", 108, "Hài", "2D"),
                    new Phim(8, "Quỷ Nhập Tràng", 95, "Kinh Dị", "3D"),
                    new Phim(9, "Chuyện Ma Gần Nhà", 100, "Kinh Dị", "2D"),
                    new Phim(10, "Thanh Sói", 130, "Hành Động", "3D"),
                    new Phim(11, "Trạng Tí Phiêu Lưu Ký", 105, "Phiêu Lưu", "2D"),
                    new Phim(12, "Lật Mặt: Nhà Có Khách", 110, "Kinh Dị", "3D"),
                    new Phim(13, "Địa Đạo", 90, "Hành Động", "2D"),
                    new Phim(14, "Đảo Độc Đắc: Tử Mẫu Thiên Linh Cái", 100, "Kinh Dị", "2D"),
                    new Phim(15, "Nụ Hôn Bạc Tỷ", 95, "Tình Cảm", "2D")
                };

                foreach (var phim in danhSachPhim)
                {
                    BLL_Phim.Instance.AddPhim(phim);
                }
            }

            dataGridViewPhim.DataSource = BLL_Phim.Instance.GetAllPhim();
            dataGridViewPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Load thể loại vào ComboBox
        private void LoadTheLoai()
        {
            comboBoxTheLoai.Items.Clear();
            // Giả sử bạn có danh sách thể loại từ một nguồn nào đó
            var theLoais = new List<string> { "Hành Động", "Hài", "Kinh Dị", "Tình Cảm" };
            foreach (var tl in theLoais)
            {
                comboBoxTheLoai.Items.Add(tl);
            }
        }

        // Thêm phim
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txtTenPhim.Text) ||
                string.IsNullOrWhiteSpace(txtThoiLuong.Text) ||
                string.IsNullOrWhiteSpace(comboBoxTheLoai.Text) ||
                string.IsNullOrWhiteSpace(txtDinhDang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phim!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thời lượng phim có phải là số nguyên không
            if (!int.TryParse(txtThoiLuong.Text.Trim(), out int thoiLuong))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng thời lượng (số nguyên)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo phim
            var phim = new Phim(
                Id: BLL_Phim.Instance.GetAllPhim().Count + 1, // Tạo ID mới
                TenPhim: txtTenPhim.Text.Trim(),
                ThoiLuong: thoiLuong,
                TheLoai: comboBoxTheLoai.Text.Trim(),
                DinhDang: txtDinhDang.Text.Trim()
            );

            // Thêm phim vào danh sách
            if (BLL_Phim.Instance.AddPhim(phim))
            {
                MessageBox.Show("Thêm phim thành công!");
                LoadData(); // Cập nhật danh sách phim
            }
            else
            {
                MessageBox.Show("Phim đã tồn tại.");
            }
        }

        // Cập nhật phim
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phim để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txtTenPhim.Text) ||
            string.IsNullOrWhiteSpace(txtThoiLuong.Text) ||
            string.IsNullOrWhiteSpace(comboBoxTheLoai.Text) ||
            string.IsNullOrWhiteSpace(txtDinhDang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridViewPhim.SelectedRows[0].Cells["Id"].Value);

            var phim = new Phim(
                Id: id,
                TenPhim: txtTenPhim.Text.Trim(),
                ThoiLuong: Convert.ToInt32(txtThoiLuong.Text.Trim()),
                TheLoai: comboBoxTheLoai.Text.Trim(),
                DinhDang: txtDinhDang.Text.Trim()
            );

            // Cập nhật phim
            if (BLL_Phim.Instance.UpdatePhim(phim))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData(); // Cập nhật danh sách phim
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        // Xóa phim
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phim để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridViewPhim.SelectedRows[0].Cells["Id"].Value);

            // Xóa phim
            BLL_Phim.Instance.DeletePhim(id);
            MessageBox.Show("Xóa phim thành công!");
            LoadData(); // Cập nhật danh sách phim
        }

        // Khi chọn một dòng trong DataGridView, hiển thị thông tin phim lên các TextBox và poster phim
        private void dataGridViewPhim_SelectionChanged(object sender, EventArgs e)
{
    if (dataGridViewPhim.SelectedRows.Count > 0)
    {
        string tenPhim = dataGridViewPhim.SelectedRows[0].Cells["TenPhim"].Value.ToString();

        // Chuyển tên phim thành tên file ảnh: không dấu, viết thường, bỏ khoảng trắng
        string tenFileAnh = ChuyenDoiTenPhimThanhTenFile(tenPhim) + ".jpg";

        string duongDan = Path.Combine(Application.StartupPath, tenFileAnh);

        if (File.Exists(duongDan))
        {
            try
            {
                using (FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read))
                {
                    Image image = Image.FromStream(fs);
                    pictureBoxPoster.Image = new Bitmap(image, new Size(200, 300));
                    pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
        }
        else
        {
            pictureBoxPoster.Image = null;
            MessageBox.Show($"Không tìm thấy ảnh poster cho phim: {tenPhim}\nĐường dẫn: {duongDan}");
        }
    }
}
        private string ChuyenDoiTenPhimThanhTenFile(string tenPhim)
        {
            string normalized = tenPhim.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (char c in normalized)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            string result = sb.ToString().Normalize(NormalizationForm.FormC);
            result = result.ToLower().Replace(" ", "").Replace("-", "").Replace("_", "");
            return result;
        }



        // Tìm kiếm phim theo tên
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTenPhim.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập tên phim cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = BLL_Phim.Instance.GetPhimByName(keyword);
            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phim nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridViewPhim.DataSource = result;
        }
    }
}
