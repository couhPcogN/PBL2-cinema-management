using System;

namespace PBL2.DTO
{
    public class DinhDangPhim
    {
        public int MaDinhDang { get; set; }
        public string TenDinhDang { get; set; }

        public DinhDangPhim(int maDinhDang, string tenDinhDang)
        {
            MaDinhDang = maDinhDang;
            TenDinhDang = tenDinhDang;
        }

        public override string ToString()
        {
            return $"[{MaDinhDang}] {TenDinhDang}";
        }
    }
}
