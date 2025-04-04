using PBL2.DTO;
using System;
using System.Collections.Generic;

namespace PBL2.BLL
{
    class BLL_ThongKe
    {
        // Design Pattern Singleton
        #region Design Pattern
        private static BLL_ThongKe _Instance = null;
        public static BLL_ThongKe Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_ThongKe();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_ThongKe() { }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<ThongKe> GetAllThongKe()
        {
            return new List<ThongKe>(); // Tạm thời trả về danh sách rỗng
        }
        public ThongKe GetThongKeByDate(DateTime date)
        {
            return new ThongKe(0, date, 0, 0); // Tạm thời trả về đối tượng mặc định
        }
        #endregion

        // Tạo báo cáo thống kê
        #region Report Generation
        public ThongKe GenerateReport(DateTime date)
        {
            int soLuongVeBan = 100; // Giả lập dữ liệu
            decimal tongDoanhThu = 1000000; // Giả lập dữ liệu
            return new ThongKe(1, date, soLuongVeBan, tongDoanhThu);
        }
        #endregion
    }
}
