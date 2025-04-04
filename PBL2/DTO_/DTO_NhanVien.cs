using System;

namespace PBL2.DTO
{
    class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public NhanVien(int maNV, string tenNV, string chucVu, DateTime ngaySinh, string diaChi, string soDienThoai)
        {
            MaNV = maNV;
            TenNV = tenNV;
            ChucVu = chucVu;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public override string ToString()
        {
            return $"[{MaNV}] {TenNV} - {ChucVu}";
        }
    }
}
