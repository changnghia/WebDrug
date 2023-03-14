using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBanThuoc.Data;
using WebBanThuoc.Data.Reponsitory.User;
using WebBanThuoc.DTOs;
using WebBanThuoc.Web.Models;

namespace WebBanThuoc.Web.Controllers
{
    public class HomeController : Controller
    {
        public ShowClientRepository repo;
        public HomeController()
        {           
            repo = new ShowClientRepository();
        }

        public IActionResult Index(string seachThuoc,int page=1)
        {
            X.PagedList.IPagedList<Thuoc> data;
            if (!String.IsNullOrEmpty(seachThuoc))
            {
                 data = repo.seachData(page,seachThuoc);
            }
            else
            {
                data = repo.ListData(page);
            }
            return View(data);
        }
        public IActionResult List(string seachThuoc, int page = 1)
        {
            X.PagedList.IPagedList<Thuoc> data;
            if (!String.IsNullOrEmpty(seachThuoc))
            {
                data = repo.seachData(page, seachThuoc);
            }
            else
            {
                data = repo.ListData(page);
            } 
             return PartialView(data);
        }
        public async Task<IActionResult> Cart(List<int> idList)
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            if (idList.Count == 0)
            {
                return Ok();
            }
            else
            {
                List<Thuoc> response = new List<Thuoc>();
                foreach (var item in idList)
                {
                    response.Add(await db.thuocs.AsNoTracking().Where(x => x.Id == item).SingleOrDefaultAsync());
                }
                return Ok(response);
            }
        }
        public IActionResult ViewSignUp()
        {
            return PartialView();
        }
        public IActionResult XemThuoc(int id)
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            var data = db.thuocs.Find(id);
            data.nhaCungCap = db.nhaCungCaps.Find(data.IdNhaCungCap);
            return PartialView(data);
        }
    }
}
