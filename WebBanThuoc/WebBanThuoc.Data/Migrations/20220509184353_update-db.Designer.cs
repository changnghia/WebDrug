﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBanThuoc.Data;

namespace WebBanThuoc.Data.Migrations
{
    [DbContext(typeof(WebBanThuocDbContext))]
    [Migration("20220509184353_update-db")]
    partial class updatedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBanThuoc.DTOs.ChiTietDonHang", b =>
                {
                    b.Property<int>("IdDonHang")
                        .HasColumnType("int");

                    b.Property<int>("IdThuoc")
                        .HasColumnType("int");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdDonHang", "IdThuoc");

                    b.HasIndex("IdThuoc");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.DonHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TongSoTien")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngaydat")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdTaiKhoan");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.NhaCungCap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhaCungCap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.PhanLoaiThuoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoaiThuoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("phanLoaiThuocs");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<byte[]>("PassworkHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PassworkSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.Thuoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CongDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DVT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DaBan")
                        .HasColumnType("int");

                    b.Property<int>("GiaTien")
                        .HasColumnType("int");

                    b.Property<int?>("IdLoaiThuoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdNhaCungCap")
                        .HasColumnType("int");

                    b.Property<int?>("IdTaiKhoan")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenThuoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duongdan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiThuoc");

                    b.HasIndex("IdNhaCungCap");

                    b.HasIndex("IdTaiKhoan");

                    b.ToTable("Thuoc");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.ChiTietDonHang", b =>
                {
                    b.HasOne("WebBanThuoc.DTOs.DonHang", "donHang")
                        .WithMany("chiTietDonHangs")
                        .HasForeignKey("IdDonHang")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebBanThuoc.DTOs.Thuoc", "thuoc")
                        .WithMany("chiTietDonHangs")
                        .HasForeignKey("IdThuoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("donHang");

                    b.Navigation("thuoc");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.DonHang", b =>
                {
                    b.HasOne("WebBanThuoc.DTOs.TaiKhoan", "taikhoan")
                        .WithMany("donHangs")
                        .HasForeignKey("IdTaiKhoan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("taikhoan");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.Thuoc", b =>
                {
                    b.HasOne("WebBanThuoc.DTOs.PhanLoaiThuoc", "phanLoaiThuoc")
                        .WithMany("thuocs")
                        .HasForeignKey("IdLoaiThuoc");

                    b.HasOne("WebBanThuoc.DTOs.NhaCungCap", "nhaCungCap")
                        .WithMany("thuocs")
                        .HasForeignKey("IdNhaCungCap");

                    b.HasOne("WebBanThuoc.DTOs.TaiKhoan", "taiKhoan")
                        .WithMany("thuocs")
                        .HasForeignKey("IdTaiKhoan");

                    b.Navigation("nhaCungCap");

                    b.Navigation("phanLoaiThuoc");

                    b.Navigation("taiKhoan");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.DonHang", b =>
                {
                    b.Navigation("chiTietDonHangs");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.NhaCungCap", b =>
                {
                    b.Navigation("thuocs");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.PhanLoaiThuoc", b =>
                {
                    b.Navigation("thuocs");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.TaiKhoan", b =>
                {
                    b.Navigation("donHangs");

                    b.Navigation("thuocs");
                });

            modelBuilder.Entity("WebBanThuoc.DTOs.Thuoc", b =>
                {
                    b.Navigation("chiTietDonHangs");
                });
#pragma warning restore 612, 618
        }
    }
}
