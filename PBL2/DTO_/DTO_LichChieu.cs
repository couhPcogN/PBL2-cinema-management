using System;

namespace PBL2.DTO
{
    public class LichChieu
    {
        public int MaLichChieu { get; set; }
        public int MaPhim { get; set; }
        public int MaPhongChieu { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan GioChieu { get; set; }

        public LichChieu(int maLichChieu, int maPhim, int maPhongChieu, DateTime ngayChieu, TimeSpan gioChieu)
        {
            MaLichChieu = maLichChieu;
            MaPhim = maPhim;
            MaPhongChieu = maPhongChieu;
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
        }

        public override string ToString()
        {
            return $"Lịch chiếu: [Mã: {MaLichChieu}] - Phim: {MaPhim} - Phòng: {MaPhongChieu} - Ngày: {NgayChieu:dd/MM/yyyy} - Giờ: {GioChieu}";
        }
    }
}
