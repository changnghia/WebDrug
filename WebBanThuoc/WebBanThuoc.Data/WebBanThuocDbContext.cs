using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBanThuoc.DTOs;

namespace WebBanThuoc.Data
{
    public class WebBanThuocDbContext : DbContext
    {
        public DbSet<NhaCungCap> nhaCungCaps { get; set; }
        public DbSet<Thuoc> thuocs { get; set; }
        public DbSet<TaiKhoan> taiKhoans { get; set; }
        public DbSet<PhanLoaiThuoc> phanLoaiThuocs { get; set; }
        public DbSet<DonHang> donHangs { get; set; }
        public DbSet<ChiTietDonHang> chiTietDonHangs { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=WebBanThuoc;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ChiTietDonHang>()
                .HasKey(x => new
                {
                    x.IdDonHang,
                    x.IdThuoc
                });
            modelBuilder.Entity<ChiTietDonHang>()
                .HasOne(x => x.donHang)
                .WithMany(x => x.chiTietDonHangs)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
