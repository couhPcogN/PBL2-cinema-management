using PBL2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL2.DAL
{
    class DAL_Ve
    {
        // Singleton Pattern
        #region Singleton
        private static DAL_Ve _Instance = null;
        public static DAL_Ve Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_Ve();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_Ve() { }
        #endregion

        // Danh sách vé
        private List<Ve> danhSachVe = new List<Ve>();

        // Thêm vé
        public bool AddVe(Ve ve)
        {
            danhSachVe.Add(ve);
            return true;
        }

        // Xóa vé
        public bool DeleteVe(int id)
        {
            var ve = danhSachVe.FirstOrDefault(x => x.MaVe == id);
            if (ve != null)
            {
                danhSachVe.Remove(ve);
                return true;
            }
            return false;
        }

        // Cập nhật vé
        public bool UpdateVe(Ve ve)
        {
            var veCu = danhSachVe.FirstOrDefault(x => x.MaVe == ve.MaVe);
            if (veCu != null)
            {
                veCu = ve;
                return true;
            }
            return false;
        }

        // Lấy danh sách vé
        public List<Ve> GetAllVe()
        {
            return danhSachVe;
        }

        // Lấy vé theo ID
        public Ve GetVeById(int id)
        {
            return danhSachVe.FirstOrDefault(x => x.MaVe == id);
        }
    }
}
