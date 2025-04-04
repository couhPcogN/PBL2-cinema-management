using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_TheLoai
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_TheLoai _Instance = null;
        public static BLL_TheLoai Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_TheLoai();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_TheLoai() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<TheLoai> GetAllTheLoai()
        {
            return new List<TheLoai>(); // Tạm thời trả về danh sách rỗng
        }
        public TheLoai GetTheLoaiById(int id)
        {
            return new TheLoai(id, "Thể loại mẫu"); // Tạm thời trả về một thể loại mẫu
        }
        #endregion

        // Xử lý thêm, sửa, xóa
        #region CRUD Operations
        public bool AddTheLoai(TheLoai theLoai)
        {
            return true; // Giả lập thêm thành công
        }
        public bool UpdateTheLoai(TheLoai theLoai)
        {
            return true; // Giả lập cập nhật thành công
        }
        public bool DeleteTheLoai(int id)
        {
            return true; // Giả lập xóa thành công
        }
        #endregion
    }
}
