using System;
using System.Collections.Generic;
using PBL2.DTO;

namespace PBL2.BLL
{
    class BLL_LichChieu
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_LichChieu _Instance = null;
        public static BLL_LichChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_LichChieu();
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
        private BLL_LichChieu() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        private List<LichChieu> danhSachLichChieu = new List<LichChieu>();

        public List<LichChieu> GetAllLichChieu()
        {
            return danhSachLichChieu;
        }

        public LichChieu GetLichChieuById(int maLichChieu)
        {
            return danhSachLichChieu.Find(lc => lc.MaLichChieu == maLichChieu);
        }

        public List<LichChieu> GetLichChieuByDate(DateTime date)
        {
            return danhSachLichChieu.FindAll(lc => lc.NgayChieu.Date == date.Date);
        }
        #endregion

        // Thao tác dữ liệu
        #region Data Manipulation
        public void AddLichChieu(LichChieu lichChieu)
        {
            danhSachLichChieu.Add(lichChieu);
        }

        public void DeleteLichChieu(int maLichChieu)
        {
            danhSachLichChieu.RemoveAll(lc => lc.MaLichChieu == maLichChieu);
        }

        public void UpdateLichChieu(LichChieu lichChieu)
        {
            for (int i = 0; i < danhSachLichChieu.Count; i++)
            {
                if (danhSachLichChieu[i].MaLichChieu == lichChieu.MaLichChieu)
                {
                    danhSachLichChieu[i] = lichChieu;
                    break;
                }
            }
        }
        #endregion
    }
}
