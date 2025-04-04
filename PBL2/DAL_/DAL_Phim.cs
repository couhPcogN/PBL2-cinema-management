using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.DAL
{
    class DAL_Phim
    {
        // Singleton Pattern
        #region Design Pattern
        private static DAL_Phim _Instance = null;
        public static DAL_Phim Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Phim();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Danh sách phim (dữ liệu trong bộ nhớ)
        private List<Phim> danhSachPhim;

        // Constructor
        #region Constructor
        private DAL_Phim()
        {
            danhSachPhim = new List<Phim>();
        }
        #endregion

        // Lấy danh sách phim
        #region Get Data
        public List<Phim> GetAllPhim()
        {
            return danhSachPhim;
        }

        public Phim GetPhimById(int id)
        {
            return danhSachPhim.Find(p => p.Id == id);
        }
        #endregion

        // Thao tác thêm, sửa, xóa
        #region CRUD Operations
        public bool AddPhim(Phim p)
        {
            if (GetPhimById(p.Id) == null)
            {
                danhSachPhim.Add(p);
                return true;
            }
            return false;
        }

        public bool UpdatePhim(Phim p)
        {
            var phim = GetPhimById(p.Id);
            if (phim != null)
            {
                phim.TenPhim = p.TenPhim;
                phim.ThoiLuong = p.ThoiLuong;
                phim.TheLoai = p.TheLoai;
                phim.DinhDang = p.DinhDang;
                return true;
            }
            return false;
        }

        public bool DeletePhim(int id)
        {
            var phim = GetPhimById(id);
            if (phim != null)
            {
                danhSachPhim.Remove(phim);
                return true;
            }
            return false;
        }
        #endregion
    }
}
