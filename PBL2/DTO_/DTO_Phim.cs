namespace PBL2.DTO
{
    public class Phim
    {
        public int Id { get; set; }
        public string TenPhim { get; set; }
        public int ThoiLuong { get; set; }
        public string TheLoai { get; set; }
        public string DinhDang { get; set; }

        public Phim(int id, string tenPhim, int thoiLuong, string theLoai, string dinhDang, int Id, object TenPhim, int ThoiLuong, string TheLoai, string DinhDang)
        {
            Id = id;
            TenPhim = tenPhim;
            ThoiLuong = thoiLuong;
            TheLoai = theLoai;
            DinhDang = dinhDang;
            this.Id = Id;
            this.ThoiLuong = ThoiLuong;
            this.TheLoai = TheLoai;
            this.DinhDang = DinhDang;
        }

        public Phim(int Id, string TenPhim, int ThoiLuong, string TheLoai, string DinhDang)
        {
            this.Id = Id;
            this.TenPhim = TenPhim;
            this.ThoiLuong = ThoiLuong;
            this.TheLoai = TheLoai;
            this.DinhDang = DinhDang;
        }
    }
}
