using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_PhongChieu
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_PhongChieu _Instance = null;
        public static BLL_PhongChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_PhongChieu();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_PhongChieu() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<PhongChieu> GetAllPhongChieu()
        {
            return new List<PhongChieu>(); // Tạm thời trả về danh sách rỗng
        }
        public PhongChieu GetPhongChieuById(int maPhong)
        {
            return new PhongChieu(maPhong, "", 0, ""); // Tạm thời trả về phòng chiếu mặc định
        }
        #endregion

        // Thêm, sửa, xóa
        #region Add, Edit, Delete
        public bool AddPhongChieu(PhongChieu phongChieu)
        {
            // Thêm phòng chiếu vào danh sách (chưa có dữ liệu thực)
            return true;
        }
        public bool UpdatePhongChieu(PhongChieu phongChieu)
        {
            // Cập nhật thông tin phòng chiếu (chưa có dữ liệu thực)
            return true;
        }
        public bool DeletePhongChieu(int maPhong)
        {
            // Xóa phòng chiếu theo mã (chưa có dữ liệu thực)
            return true;
        }
        #endregion
    }
}
