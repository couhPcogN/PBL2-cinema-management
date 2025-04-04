using System;

namespace PBL2.DTO
{
    public class TheLoai
    {
        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        public TheLoai(int maTheLoai, string tenTheLoai)
        {
            MaTheLoai = maTheLoai;
            TenTheLoai = tenTheLoai;
        }

        public override string ToString()
        {
            return $"[{MaTheLoai}] {TenTheLoai}";
        }
    }
}
