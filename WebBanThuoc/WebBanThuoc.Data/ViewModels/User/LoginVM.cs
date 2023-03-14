using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.Data.ViewModels.User
{
    public class LoginVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Check { get; set; }
    }
}
