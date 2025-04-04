using System;

namespace PBL2.DTO
{
    public class Ve
    {
        private int v1;
        private string v2;
        private int v3;
        private DateTime now;

        public int MaVe { get; set; }
        public int MaLichChieu { get; set; }
        public string MaGheNgoi { get; set; }
        public float TienBanVe { get; set; }
        public int TrangThai { get; set; }  // 0: Chưa bán, 1: Đã bán
        public DateTime NgayBan { get; set; }  // Thêm thuộc tính này

        public Ve(int maVe, int maLichChieu, string maGheNgoi, float tienBanVe, int trangThai, DateTime ngayBan)
        {
            MaVe = maVe;
            MaLichChieu = maLichChieu;
            MaGheNgoi = maGheNgoi;
            TienBanVe = tienBanVe;
            TrangThai = trangThai;
            NgayBan = ngayBan;  // Gán giá trị
        }

        public Ve(int maVe, int v1, string v2, int v3, DateTime now)
        {
            MaVe = maVe;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.now = now;
        }

        public override string ToString()
        {
            return $"[Mã vé: {MaVe}] - Lịch chiếu: {MaLichChieu} - Ghế: {MaGheNgoi} - Giá vé: {TienBanVe} - Ngày bán: {NgayBan.ToShortDateString()} - Trạng thái: {(TrangThai == 1 ? "Đã bán" : "Chưa bán")}";
        }
    }
}
