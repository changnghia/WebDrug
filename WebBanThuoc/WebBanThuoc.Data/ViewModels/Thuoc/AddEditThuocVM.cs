using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.Data.ViewModels.Thuoc
{
    public class AddEditThuocVM
    {
        public int Id { get; set; }
        public string TenThuoc { get; set; }
        public string CongDung { get; set; }
        public string DVT { get; set; }
        public int GiaTien { get; set; }
        public int SoLuong { get; set; }
        public IFormFile Hinh { get; set; }
        public string duongdan { get; set; }
        public int DaBan { get; set; }
        public int? IdLoaiThuoc { get; set; }
        public int? IdTaiKhoan { get; set; }
        public int? IdNhaCungCap { get; set; }
    }
}
