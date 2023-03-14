using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.Data.ViewModels.ListClientThuoc
{
    public class ListClentThuoc
    {
        public int Id { get; set; }
        public string TenThuoc { get; set; }
        public string CongDung { get; set; }
        public string DVT { get; set; }
        public int GiaTien { get; set; }
        public int SoLuong { get; set; }
        public int? DaBan { get; set; }
        public string LoaiThuoc { get; set; }
       
    }
}
