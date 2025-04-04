using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_LichChieuView
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_LichChieuView _Instance = null;
        public static BLL_LichChieuView Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_LichChieuView();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_LichChieuView() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<LichChieuView> GetAllLichChieu()
        {
            return new List<LichChieuView>(); // Tạm thời trả về danh sách rỗng
        }
        public LichChieuView GetLichChieuById(int id)
        {
            return new LichChieuView(id, DateTime.Now, "Phim A", "Phòng 1");
            // Tạm thời trả về lịch chiếu mẫu
        }
        #endregion

        // Xử lý thêm, sửa, xóa
        #region CRUD Operations
        public bool AddLichChieu(LichChieuView lc)
        {
            return true; // Giả lập thêm thành công
        }
        public bool UpdateLichChieu(LichChieuView lc)
        {
            return true; // Giả lập cập nhật thành công
        }
        public bool DeleteLichChieu(int id)
        {
            return true; // Giả lập xóa thành công
        }
        #endregion
    }
}
