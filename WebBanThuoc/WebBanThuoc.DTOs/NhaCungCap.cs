using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.DTOs
{
    [Table("NhaCungCap")]
    public class NhaCungCap
    {
        public NhaCungCap()
        {
            thuocs = new HashSet<Thuoc>();
        }
        [Key]
        public int Id { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Gmail { get; set; }
        public ICollection<Thuoc> thuocs { get; set; }
    }
}
