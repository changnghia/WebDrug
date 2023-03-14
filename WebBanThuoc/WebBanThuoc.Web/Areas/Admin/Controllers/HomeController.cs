using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThuoc.Data;
using WebBanThuoc.Data.ViewModels.ThongKe;
using WebBanThuoc.DTOs;
using X.PagedList;

namespace WebBanThuoc.Web.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThongKe()
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            List<IGrouping<string, DonHang>> listdata = db.donHangs
                .AsEnumerable()
                .GroupBy(x => x.ngaydat.ToString("dd//MM/yyyy")).ToList();
            List<ThongKeVM> data = new List<ThongKeVM>();

            foreach (var item in listdata)
            {
                ThongKeVM itemp = new ThongKeVM();

                foreach (var gia in item)
                {
                    itemp.date = gia.ngaydat;
                    itemp.value += gia.TongSoTien;
                }
                data.Add(itemp);
            }
            return new JsonResult(data);
        }
        public IActionResult ListCartofUser(int page = 1)
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            var data = db.donHangs
               .Include(x => x.chiTietDonHangs)
               .OrderByDescending(u => u.Id)
               .ToPagedList(page, 3);
            foreach (var item in data)
            {
                foreach (var itemps in item.chiTietDonHangs)
                {
                    var monan = db.thuocs.Find(itemps.IdThuoc);
                    itemps.thuoc = monan;
                }
            }
            return View(data);
        }
        public IActionResult XacDanDonHang(int id)
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            var data = db.donHangs.Find(id);
            data.Trangthai = true;
            db.donHangs.Update(data);
            db.SaveChanges();
            return RedirectToAction("ListCartofUser", "Home");
        }
    }
}
