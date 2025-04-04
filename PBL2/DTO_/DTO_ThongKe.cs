using System;

namespace PBL2.DTO
{
    public class ThongKe
    {
        public int MaThongKe { get; set; }
        public DateTime NgayThongKe { get; set; }
        public int SoLuongVeBan { get; set; }
        public decimal TongDoanhThu { get; set; }

        public ThongKe(int maThongKe, DateTime ngayThongKe, int soLuongVeBan, decimal tongDoanhThu)
        {
            MaThongKe = maThongKe;
            NgayThongKe = ngayThongKe;
            SoLuongVeBan = soLuongVeBan;
            TongDoanhThu = tongDoanhThu;
        }

        public override string ToString()
        {
            return $"[{MaThongKe}] {NgayThongKe.ToShortDateString()} - Vé bán: {SoLuongVeBan} - Doanh thu: {TongDoanhThu:C}";
        }
    }
}
