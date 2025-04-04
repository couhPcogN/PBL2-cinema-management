using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_LoaiManHinh
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_LoaiManHinh _Instance = null;
        public static BLL_LoaiManHinh Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_LoaiManHinh();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_LoaiManHinh() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<LoaiManHinh> GetAllLoaiManHinh()
        {
            return new List<LoaiManHinh>(); // Tạm thời trả về danh sách rỗng
        }
        public LoaiManHinh GetLoaiManHinhById(int id)
        {
            return new LoaiManHinh(id, "Màn hình mẫu"); // Tạm thời trả về một loại màn hình mẫu
        }
        #endregion

        // Xử lý thêm, sửa, xóa
        #region CRUD Operations
        public bool AddLoaiManHinh(LoaiManHinh loaiManHinh)
        {
            return true; // Giả lập thêm thành công
        }
        public bool UpdateLoaiManHinh(LoaiManHinh loaiManHinh)
        {
            return true; // Giả lập cập nhật thành công
        }
        public bool DeleteLoaiManHinh(int id)
        {
            return true; // Giả lập xóa thành công
        }
        #endregion
    }
}
