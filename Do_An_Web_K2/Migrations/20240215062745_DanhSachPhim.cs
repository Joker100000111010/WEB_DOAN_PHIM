using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Do_An_Web_K2.Migrations
{
    /// <inheritdoc />
    public partial class DanhSachPhim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformationPhim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDePhim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoNamPhim = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationPhim", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "InformationPhim",
                columns: new[] { "Id", "Image", "SoNamPhim", "TieuDePhim", "TrangThai", "Video" },
                values: new object[,]
                {
                    { 1, "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg", 25, "America", "HD Vietsub", "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html" },
                    { 2, "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg", 25, "America", "HD Vietsub", "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html" },
                    { 3, "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg", 25, "America", "HD Vietsub", "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html" },
                    { 4, "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg", 25, "America", "HD Vietsub", "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformationPhim");
        }
    }
}
