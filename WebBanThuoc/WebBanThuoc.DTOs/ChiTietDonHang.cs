using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.DTOs
{
    [Table("ChiTietDonHang")]
    public class ChiTietDonHang
    {
        
        public int IdDonHang { get; set; }
        [ForeignKey(nameof(IdDonHang))]
        public DonHang donHang { get; set; }
        public int IdThuoc { get; set; }
        [ForeignKey(nameof(IdThuoc))]
        public Thuoc thuoc { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }       
    }
}
