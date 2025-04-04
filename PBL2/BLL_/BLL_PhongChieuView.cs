using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_PhongChieuView
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_PhongChieuView _Instance = null;
        public static BLL_PhongChieuView Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_PhongChieuView();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_PhongChieuView() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<PhongChieuView> GetAllPhongChieu()
        {
            return new List<PhongChieuView>(); // Tạm thời trả về danh sách rỗng
        }

        public PhongChieuView GetPhongChieuById(int id)
        {
            return new PhongChieuView(id, "Phòng 1", 100, "Màn hình lớn");
            // Tạm thời trả về phòng chiếu mẫu
        }
        #endregion

        // Xử lý thêm, sửa, xóa
        #region CRUD Operations
        public bool AddPhongChieu(PhongChieuView pc)
        {
            return true; // Giả lập thêm thành công
        }

        public bool UpdatePhongChieu(PhongChieuView pc)
        {
            return true; // Giả lập cập nhật thành công
        }

        public bool DeletePhongChieu(int id)
        {
            return true; // Giả lập xóa thành công
        }
        #endregion
    }
}
