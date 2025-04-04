using System;

namespace PBL2.DTO
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string LoaiTaiKhoan { get; set; }

        public TaiKhoan(string tenDangNhap, string matKhau, string loaiTaiKhoan)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            LoaiTaiKhoan = loaiTaiKhoan;
        }

        public override string ToString()
        {
            return $"[{LoaiTaiKhoan}] {TenDangNhap}";
        }
    }
}
