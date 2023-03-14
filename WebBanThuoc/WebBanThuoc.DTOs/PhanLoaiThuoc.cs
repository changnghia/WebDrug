using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.DTOs
{
    public class PhanLoaiThuoc
    {
        public PhanLoaiThuoc()
        {
            thuocs = new HashSet<Thuoc>();
        }
        [Key]
        public int Id { get; set; }
        public string LoaiThuoc { get; set; }
        public ICollection<Thuoc> thuocs { get; set; }
    }
}
