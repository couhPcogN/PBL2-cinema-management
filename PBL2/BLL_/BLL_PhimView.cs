using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_PhimView
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_PhimView _Instance = null;
        public static BLL_PhimView Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_PhimView();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_PhimView() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<PhimView> GetAllPhim()
        {
            return new List<PhimView>(); // Tạm thời trả về danh sách rỗng
        }
        public PhimView GetPhimById(int id)
        {
            return new PhimView(id, "Phim A", "Hành động", "2D", 120, DateTime.Now);
            // Tạm thời trả về phim mẫu
        }
        #endregion

        // Xử lý thêm, sửa, xóa
        #region CRUD Operations
        public bool AddPhim(PhimView phim)
        {
            return true; // Giả lập thêm thành công
        }
        public bool UpdatePhim(PhimView phim)
        {
            return true; // Giả lập cập nhật thành công
        }
        public bool DeletePhim(int id)
        {
            return true; // Giả lập xóa thành công
        }
        #endregion
    }
}
