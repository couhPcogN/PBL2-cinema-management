using System;

namespace PBL2.DTO
{
    public class PhimView
    {
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string TheLoai { get; set; }
        public string DinhDang { get; set; }
        public int ThoiLuong { get; set; }
        public DateTime NgayKhoiChieu { get; set; }

        public PhimView(int maPhim, string tenPhim, string theLoai, string dinhDang, int thoiLuong, DateTime ngayKhoiChieu)
        {
            MaPhim = maPhim;
            TenPhim = tenPhim;
            TheLoai = theLoai;
            DinhDang = dinhDang;
            ThoiLuong = thoiLuong;
            NgayKhoiChieu = ngayKhoiChieu;
        }

        public override string ToString()
        {
            return $"[{MaPhim}] {TenPhim} - {TheLoai} - {DinhDang} - {ThoiLuong} phút - Khởi chiếu: {NgayKhoiChieu:dd/MM/yyyy}";
        }
    }
}
