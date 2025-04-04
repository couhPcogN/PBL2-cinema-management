using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_DinhDangPhim
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_DinhDangPhim _Instance = null;
        public static BLL_DinhDangPhim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_DinhDangPhim();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_DinhDangPhim() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<DinhDangPhim> GetAllDinhDangPhim()
        {
            return new List<DinhDangPhim>(); // Tạm thời trả về danh sách rỗng
        }
        public DinhDangPhim GetDinhDangPhimById(int id)
        {
            return new DinhDangPhim(id, "Định dạng mẫu"); // Tạm thời trả về một định dạng mẫu
        }
        #endregion

        // Xử lý thêm, sửa, xóa
        #region CRUD Operations
        public bool AddDinhDangPhim(DinhDangPhim ddp)
        {
            return true; // Giả lập thêm thành công
        }
        public bool UpdateDinhDangPhim(DinhDangPhim ddp)
        {
            return true; // Giả lập cập nhật thành công
        }
        public bool DeleteDinhDangPhim(int id)
        {
            return true; // Giả lập xóa thành công
        }
        #endregion
    }
}
