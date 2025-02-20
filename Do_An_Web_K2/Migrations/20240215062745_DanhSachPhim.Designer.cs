﻿// <auto-generated />
using Do_An_Web_K2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Do_An_Web_K2.Migrations
{
    [DbContext(typeof(PhimDbContext))]
    [Migration("20240215062745_DanhSachPhim")]
    partial class DanhSachPhim
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Do_An_Web_K2.Models.InformationPhim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoNamPhim")
                        .HasColumnType("int");

                    b.Property<string>("TieuDePhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InformationPhim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg",
                            SoNamPhim = 25,
                            TieuDePhim = "America",
                            TrangThai = "HD Vietsub",
                            Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html"
                        },
                        new
                        {
                            Id = 2,
                            Image = "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg",
                            SoNamPhim = 25,
                            TieuDePhim = "America",
                            TrangThai = "HD Vietsub",
                            Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html"
                        },
                        new
                        {
                            Id = 3,
                            Image = "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg",
                            SoNamPhim = 25,
                            TieuDePhim = "America",
                            TrangThai = "HD Vietsub",
                            Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html"
                        },
                        new
                        {
                            Id = 4,
                            Image = "/Web/DoAnWeb/images/Thể loại/Hài hước/Bố già/Bố già.jpg",
                            SoNamPhim = 25,
                            TieuDePhim = "America",
                            TrangThai = "HD Vietsub",
                            Video = "/Web/DoAnWeb/chạy_demo__video/Page/demo_phim.html"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
