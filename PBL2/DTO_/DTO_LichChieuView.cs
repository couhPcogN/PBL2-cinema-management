using System;

namespace PBL2.DTO
{
    public class LichChieuView
    {
        public int MaLichChieu { get; set; }
        public DateTime NgayChieu { get; set; }
        public string TenPhim { get; set; }
        public string TenPhong { get; set; }

        public LichChieuView(int maLichChieu, DateTime ngayChieu, string tenPhim, string tenPhong)
        {
            MaLichChieu = maLichChieu;
            NgayChieu = ngayChieu;
            TenPhim = tenPhim;
            TenPhong = tenPhong;
        }

        public override string ToString()
        {
            return $"Lịch chiếu: {TenPhim} tại {TenPhong} - {NgayChieu:dd/MM/yyyy HH:mm}";
        }
    }
}
