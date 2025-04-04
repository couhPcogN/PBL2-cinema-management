namespace PBL2.DTO
{
    public class Phim
    {
        public int Id { get; set; }
        public string TenPhim { get; set; }
        public int ThoiLuong { get; set; }
        public string TheLoai { get; set; }
        public string DinhDang { get; set; }

        public Phim(int id, string tenPhim, int thoiLuong, string theLoai, string dinhDang)
        {
            Id = id;
            TenPhim = tenPhim;
            ThoiLuong = thoiLuong;
            TheLoai = theLoai;
            DinhDang = dinhDang;
        }
    }
}
