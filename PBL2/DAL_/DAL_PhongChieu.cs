using PBL2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL2.DAL
{
    class DAL_PhongChieu
    {
        // Singleton Pattern
        #region Singleton
        private static DAL_PhongChieu _Instance = null;
        public static DAL_PhongChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_PhongChieu();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_PhongChieu() { }
        #endregion

        // Danh sách phòng chiếu
        private List<PhongChieu> danhSachPhongChieu = new List<PhongChieu>();

        // Thêm phòng chiếu
        public bool AddPhongChieu(PhongChieu pc)
        {
            danhSachPhongChieu.Add(pc);
            return true;
        }

        // Xóa phòng chiếu
        public bool DeletePhongChieu(int id)
        {
            var pc = danhSachPhongChieu.FirstOrDefault(x => x.MaPhong == id);
            if (pc != null)
            {
                danhSachPhongChieu.Remove(pc);
                return true;
            }
            return false;
        }

        // Cập nhật phòng chiếu
        public bool UpdatePhongChieu(PhongChieu pc)
        {
            var phongChieuCu = danhSachPhongChieu.FirstOrDefault(x => x.MaPhong == pc.MaPhong);
            if (phongChieuCu != null)
            {
                phongChieuCu = pc;
                return true;
            }
            return false;
        }

        // Lấy danh sách phòng chiếu
        public List<PhongChieu> GetAllPhongChieu()
        {
            return danhSachPhongChieu;
        }

        // Lấy phòng chiếu theo ID
        public PhongChieu GetPhongChieuById(int id)
        {
            return danhSachPhongChieu.FirstOrDefault(x => x.MaPhong == id);
        }
    }
}
