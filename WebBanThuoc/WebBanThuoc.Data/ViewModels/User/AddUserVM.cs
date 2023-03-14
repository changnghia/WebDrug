using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.Data.ViewModels.User
{
    public class AddUserVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare(nameof(Password),ErrorMessage ="Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }
        public string HoTen { get; set; }
    }
}
