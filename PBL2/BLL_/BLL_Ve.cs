using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_Ve
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_Ve _Instance = null;
        public static BLL_Ve Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_Ve();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_Ve() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<Ve> GetAllVe()
        {
            return new List<Ve>(); // Tạm thời trả về danh sách rỗng
        }
        public Ve GetVeByMaVe(int maVe)
        {
            return new Ve(maVe, 0, "", 0, DateTime.Now); // Tạm thời trả về vé mặc định
        }
        public List<Ve> GetVeByLichChieu(int maLichChieu)
        {
            return new List<Ve>(); // Tạm thời trả về danh sách rỗng
        }
        #endregion

        // Thêm, sửa, xóa
        #region Add, Edit, Delete
        public bool AddVe(Ve ve)
        {
            // Thêm vé vào danh sách (chưa có dữ liệu thực)
            return true;
        }
        public bool UpdateVe(Ve ve)
        {
            // Cập nhật thông tin vé (chưa có dữ liệu thực)
            return true;
        }
        public bool DeleteVe(int maVe)
        {
            // Xóa vé theo mã (chưa có dữ liệu thực)
            return true;
        }
        #endregion
    }
}
