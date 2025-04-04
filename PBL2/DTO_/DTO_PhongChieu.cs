using System;

namespace PBL2.DTO
{
    public class PhongChieu
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int SoGhe { get; set; }
        public string LoaiManHinh { get; set; }

        public PhongChieu(int maPhong, string tenPhong, int soGhe, string loaiManHinh)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            SoGhe = soGhe;
            LoaiManHinh = loaiManHinh;
        }

        public override string ToString()
        {
            return $"[{MaPhong}] {TenPhong} - {SoGhe} ghế - Loại màn hình: {LoaiManHinh}";
        }
    }
}
