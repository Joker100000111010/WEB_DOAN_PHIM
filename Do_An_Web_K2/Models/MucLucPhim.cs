namespace Do_An_Web_K2.Models
{
    public class MucLucPhim
    {
        public int Id { get; set; }
        public string TieuDePhim { get; set; } = null!;
        public int SoNamPhim { get; set; }
        public string Image { get; set; } = null!;
        public string Video { get; set; } = null!;
        public string TrangThai { get; set; } = null!;
        public string? SeriesphimId { get; set; }
        public string? TheLoai { get; set; }
        public string? QuocGia { get; set; }
    }
}
