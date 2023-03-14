using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.DTOs
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            thuocs =new  HashSet<Thuoc>();
            donHangs = new HashSet<DonHang>();
        }
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PassworkHash { get; set; }
        public byte[] PassworkSalt { get; set; }
        public bool IsAdmin { get; set; }
        public string HoTen { get; set; }
        public ICollection<Thuoc> thuocs { get; set; }
        public ICollection<DonHang> donHangs { get; set; }
    }
}
