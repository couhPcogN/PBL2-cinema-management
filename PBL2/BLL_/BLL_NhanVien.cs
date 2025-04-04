using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_NhanVien
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_NhanVien _Instance = null;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_NhanVien();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_NhanVien() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<NhanVien> GetAllNhanVien()
        {
            return new List<NhanVien>(); // Tạm thời trả về danh sách rỗng
        }
        public NhanVien GetNhanVienById(int id)
        {
            return new NhanVien(id, "Nhân viên mẫu", "Quản lý", DateTime.Now, "Địa chỉ mẫu", "0123456789"); // Tạm thời trả về một nhân viên mẫu
        }
        #endregion

        // Xử lý thêm, sửa, xóa
        #region CRUD Operations
        public bool AddNhanVien(NhanVien nv)
        {
            return true; // Giả lập thêm thành công
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            return true; // Giả lập cập nhật thành công
        }
        public bool DeleteNhanVien(int id)
        {
            return true; // Giả lập xóa thành công
        }
        #endregion
    }
}
