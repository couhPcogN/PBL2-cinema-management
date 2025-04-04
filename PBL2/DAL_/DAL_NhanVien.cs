using PBL2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL2.DAL
{
    class DAL_NhanVien
    {
        // Singleton Pattern
        #region Singleton
        private static DAL_NhanVien _Instance = null;
        public static DAL_NhanVien Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_NhanVien();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_NhanVien() { }
        #endregion

        // Danh sách nhân viên
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();

        // Thêm nhân viên
        public bool AddNhanVien(NhanVien nv)
        {
            danhSachNhanVien.Add(nv);
            return true;
        }

        // Xóa nhân viên
        public bool DeleteNhanVien(int id)
        {
            var nv = danhSachNhanVien.FirstOrDefault(x => x.MaNV == id);
            if (nv != null)
            {
                danhSachNhanVien.Remove(nv);
                return true;
            }
            return false;
        }

        // Cập nhật nhân viên
        public bool UpdateNhanVien(NhanVien nv)
        {
            var nhanVienCu = danhSachNhanVien.FirstOrDefault(x => x.MaNV == nv.MaNV);
            if (nhanVienCu != null)
            {
                nhanVienCu = nv;
                return true;
            }
            return false;
        }

        // Lấy danh sách nhân viên
        public List<NhanVien> GetAllNhanVien()
        {
            return danhSachNhanVien;
        }

        // Lấy nhân viên theo ID
        public NhanVien GetNhanVienById(int id)
        {
            return danhSachNhanVien.FirstOrDefault(x => x.MaNV == id);
        }
    }
}
