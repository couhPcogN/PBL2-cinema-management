using System;

namespace PBL2.DTO
{
    public class LoaiManHinh
    {
        public int MaLoaiManHinh { get; set; }
        public string TenLoaiManHinh { get; set; }

        public LoaiManHinh(int maLoaiManHinh, string tenLoaiManHinh)
        {
            MaLoaiManHinh = maLoaiManHinh;
            TenLoaiManHinh = tenLoaiManHinh;
        }

        public override string ToString()
        {
            return $"[{MaLoaiManHinh}] {TenLoaiManHinh}";
        }
    }
}
