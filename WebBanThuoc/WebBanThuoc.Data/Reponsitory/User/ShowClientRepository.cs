using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBanThuoc.Data.Reponsitory.Admin;
using WebBanThuoc.DTOs;
using X.PagedList;

namespace WebBanThuoc.Data.Reponsitory.User
{
    public class ShowClientRepository:AdminRepository
    {
        public ShowClientRepository() : base() { }
        public ShowClientRepository(WebBanThuocDbContext _db) : base(_db) { }
        public X.PagedList.IPagedList<Thuoc> ListData(int page)
        {

            var data = db.thuocs.ToPagedList(page,6);
            return data;
        }
        public X.PagedList.IPagedList<Thuoc> seachData(int page,string search)
        {
            var data = db.thuocs.Where(s=>s.TenThuoc.Contains(search)).ToPagedList(page,6);
            return data;
        }
    }
}
