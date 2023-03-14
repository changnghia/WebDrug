using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBanThuoc.Data.Reponsitory.Admin
{
    public class AdminRepository
    {
        public WebBanThuocDbContext db;
        public AdminRepository()
        {
            db = new WebBanThuocDbContext();
        }
        public AdminRepository(WebBanThuocDbContext _db)
        {
            db = _db;
        }
        public async Task Save()
        {
            await db.SaveChangesAsync();
        }
        public void Copy<TModel>(TModel from, TModel to, string skipProperties = "")
        {
            var type = from.GetType();
            var arrSkipProperties = skipProperties.Split(',').Select(x => x.Trim()).ToList();
            foreach (var prop in type.GetProperties())
            {
                if (arrSkipProperties.IndexOf(prop.Name) < 0)
                {
                    prop.SetValue(to, prop.GetValue(from));
                }
            }
        }
    }
}
