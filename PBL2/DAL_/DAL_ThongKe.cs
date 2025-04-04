using PBL2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL2.DAL
{
    class DAL_ThongKe
    {
        // Singleton Pattern
        #region Singleton
        private static DAL_ThongKe _Instance = null;
        public static DAL_ThongKe Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_ThongKe();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_ThongKe() { }
        #endregion

        // Danh sách vé (giả lập)
        private List<Ve> danhSachVe = new List<Ve>();

        // Thêm vé vào danh sách (giả lập)
        public void AddVe(Ve ve)
        {
            danhSachVe.Add(ve);
        }

        // Thống kê tổng doanh thu
        public float TinhTongDoanhThu()
        {
            return danhSachVe.Where(v => v.TrangThai == 1).Sum(v => v.TienBanVe);
        }

        // Thống kê vé bán theo ngày
        public int DemVeBanTheoNgay(DateTime ngay)
        {
            return danhSachVe.Count(v => v.TrangThai == 1 && v.NgayBan.Date == ngay.Date);
        }

        // Thống kê doanh thu theo ngày
        public float TinhDoanhThuTheoNgay(DateTime ngay)
        {
            return danhSachVe
                .Where(v => v.TrangThai == 1 && v.NgayBan.Date == ngay.Date)
                .Sum(v => v.TienBanVe);
        }

        // Lấy danh sách các vé đã bán
        public List<Ve> GetVeDaBan()
        {
            return danhSachVe.Where(v => v.TrangThai == 1).ToList();
        }

        // Lấy danh sách các vé chưa bán
        public List<Ve> GetVeChuaBan()
        {
            return danhSachVe.Where(v => v.TrangThai == 0).ToList();
        }
    }
}
