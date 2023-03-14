using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.DTOs
{
    [Table("Thuoc")]
    public class Thuoc
    {
        public Thuoc()
        {
            chiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
        [Key]
        public int Id { get; set; }
        public string TenThuoc { get; set; }
        public string CongDung { get; set; }
        public string DVT { get; set; }
        public int GiaTien { get; set; }
        public int SoLuong { get; set; }
        public string duongdan { get; set; }
        public int? DaBan { get; set; }
        public int? IdLoaiThuoc { get; set; }
        [ForeignKey(nameof(IdLoaiThuoc))]
        public PhanLoaiThuoc phanLoaiThuoc { get; set; }
        public int? IdTaiKhoan { get; set; }
        [ForeignKey(nameof(IdTaiKhoan))]
        public TaiKhoan taiKhoan { get; set; }
        public int? IdNhaCungCap { get; set; }
        [ForeignKey(nameof(IdNhaCungCap))]
        public NhaCungCap nhaCungCap { get; set; }
        public ICollection<ChiTietDonHang> chiTietDonHangs { get; set; }
    }
}
