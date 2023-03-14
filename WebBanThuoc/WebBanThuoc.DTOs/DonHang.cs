using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.DTOs
{
    [Table("DonHang")]
    public class DonHang
    {
        public DonHang()
        {
            chiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
        [Key]
        public int Id { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int TongSoTien { get; set; }
        public int IdTaiKhoan { get; set; }
        [ForeignKey(nameof(IdTaiKhoan))]
        public TaiKhoan taikhoan { get; set; }
        public DateTime ngaydat { get; set; }
        public bool Trangthai { get; set; }
        public ICollection<ChiTietDonHang> chiTietDonHangs { get; set; }
    }
}
