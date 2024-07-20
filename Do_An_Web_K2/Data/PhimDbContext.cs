using Microsoft.EntityFrameworkCore;
using Do_An_Web_K2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Do_An_Web_K2.Data
{
    public class PhimDbContext : IdentityDbContext
    {
        public PhimDbContext(DbContextOptions<PhimDbContext> options) : base(options)
        {

        }
        public DbSet<InformationPhim> InformationPhim { get; set; }
        public DbSet<MucLucPhim> MucLucPhims { get; set; }
        public DbSet<BinhLuan> BinhLuans { get; set; }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<InformationPhim>().HasData(
                 new InformationPhim
                 {
                     Id = 1,
                     TieuDePhim = "One Piece Gold",
                     SoNamPhim = 2016,
                     Image = "/Web/DoAnWeb/images/Thể loại/Anime/One Piece/Movie-2/One Piece Gold.jpg",
                     Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html",
                     TrangThai = "HD Vietsub"
                 },
                  new InformationPhim
                  {
                      Id = 2,
                      TieuDePhim = "Bố già",
                      SoNamPhim = 2021,
                      Image = "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg",
                      Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html",
                      TrangThai = "HD Vietsub"
                  },
                  new InformationPhim
                  {
                      Id = 3,
                      TieuDePhim = "Bà Đồng",
                      SoNamPhim = 2021,
                      Image = "/Web/DoAnWeb/images/Thể loại/Kinh dị/Bà Đồng/BaDong.jpg",
                      Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html",
                      TrangThai = "HD Vietsub"
                  },
                  new InformationPhim
                  {
                      Id = 4,
                      TieuDePhim = "Biệt Đội Marvel: Hồi Kết",
                      SoNamPhim = 2023,
                      Image = "/Web/DoAnWeb/images/Thể loại/Phiêu lưu/Biệt đội Marvel/Biệt đội Marvel.webp",
                      Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html",
                      TrangThai = "HD Vietsub"
                  }
             );
         } */
    }
}
