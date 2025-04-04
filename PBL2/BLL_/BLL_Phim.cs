using PBL2.DTO;
using PBL2.DAL;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_Phim
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_Phim _Instance = null;
        public static BLL_Phim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_Phim();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_Phim() { }
        #endregion

        // Lấy dữ liệu từ DAL
        #region Get Data
        public List<PBL2.DTO.Phim> GetAllPhim()
        {
            return DAL_Phim.Instance.GetAllPhim();
        }

        public PBL2.DTO.Phim GetPhimById(int id)
        {
            return DAL_Phim.Instance.GetPhimById(id);
        }

        public List<PBL2.DTO.Phim> GetPhimByTheLoai(string theLoai)
        {
            return DAL_Phim.Instance.GetAllPhim().FindAll(p => p.TheLoai == theLoai);
        }

        public List<PBL2.DTO.Phim> GetPhimByName(string tenPhim)
        {
            return DAL_Phim.Instance.GetAllPhim().FindAll(p => p.TenPhim.Contains(tenPhim));
        }
        #endregion

        // Thao tác dữ liệu với DAL
        #region Data Manipulation
        // Thêm phim
        public bool AddPhim(PBL2.DTO.Phim phim)
        {
            // Kiểm tra phim đã tồn tại chưa
            if (IsExistPhim(phim))
                return false;

            // Thêm phim vào DAL
            DAL_Phim.Instance.AddPhim(phim);
            return true;
        }

        // Xóa phim
        public void DeletePhim(int id)
        {
            DAL_Phim.Instance.DeletePhim(id);
        }

        // Cập nhật phim
        public bool UpdatePhim(PBL2.DTO.Phim phim)
        {
            var existingPhim = DAL_Phim.Instance.GetPhimById(phim.Id);
            if (existingPhim == null)
                return false;

            // Cập nhật phim trong DAL
            DAL_Phim.Instance.UpdatePhim(phim);
            return true;
        }

        // Kiểm tra phim đã tồn tại hay chưa (dựa trên ID)
        public bool IsExistPhim(PBL2.DTO.Phim p)
        {
            return DAL_Phim.Instance.GetPhimById(p.Id) != null;
        }

        #endregion
    }
}
