using PBL2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL2.DAL
{
    class DAL_LichChieu
    {
        // Singleton Pattern
        #region Singleton
        private static DAL_LichChieu _Instance = null;
        public static DAL_LichChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_LichChieu();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_LichChieu() { }
        #endregion

        // Danh sách lịch chiếu
        private List<LichChieu> danhSachLichChieu = new List<LichChieu>();

        // Thêm lịch chiếu
        public bool AddLichChieu(LichChieu lc)
        {
            danhSachLichChieu.Add(lc);
            return true;
        }

        // Xóa lịch chiếu
        public bool DeleteLichChieu(int id)
        {
            var lc = danhSachLichChieu.FirstOrDefault(x => x.MaLichChieu == id);
            if (lc != null)
            {
                danhSachLichChieu.Remove(lc);
                return true;
            }
            return false;
        }

        // Cập nhật lịch chiếu
        public bool UpdateLichChieu(LichChieu lc)
        {
            var lichChieuCu = danhSachLichChieu.FirstOrDefault(x => x.MaLichChieu == lc.MaLichChieu);
            if (lichChieuCu != null)
            {
                lichChieuCu = lc;
                return true;
            }
            return false;
        }

        // Lấy danh sách lịch chiếu
        public List<LichChieu> GetAllLichChieu()
        {
            return danhSachLichChieu;
        }

        // Lấy lịch chiếu theo ID
        public LichChieu GetLichChieuById(int id)
        {
            return danhSachLichChieu.FirstOrDefault(x => x.MaLichChieu == id);
        }
    }
}
