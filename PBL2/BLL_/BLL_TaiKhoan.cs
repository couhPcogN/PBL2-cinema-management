using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_TaiKhoan
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_TaiKhoan _Instance = null;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_TaiKhoan();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_TaiKhoan() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return new List<TaiKhoan>(); // Tạm thời trả về danh sách rỗng
        }
        public TaiKhoan GetTaiKhoanByTenDangNhap(string tenDangNhap)
        {
            return new TaiKhoan(tenDangNhap, "", ""); // Tạm thời trả về tài khoản mặc định
        }
        #endregion

        // Thêm, sửa, xóa
        #region Add, Edit, Delete
        public bool AddTaiKhoan(TaiKhoan taiKhoan)
        {
            return true;
        }
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            return true;
        }
        public bool DeleteTaiKhoan(string tenDangNhap)
        {
            return true;
        }
        #endregion
    }
}
