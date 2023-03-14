using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThuoc.Data.Reponsitory.Admin;
using WebBanThuoc.Data.ViewModels;

namespace WebBanThuoc.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class NhaCungCapController : Controller
    {
        NhaCungCapRepository repo;
        public NhaCungCapController()
        {
            repo = new NhaCungCapRepository();
        }
        public IActionResult Index(int page = 1)
        {
            var listdata = repo.ListData(page);
            return View(listdata);
        }
        public IActionResult ListData(int page=1)
        {
            var listdata = repo.ListData(page);
            return PartialView(listdata);
        }
        public IActionResult ThemNhaCungCap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ThemNhaCungCap(AddorUpdateNhaCungCapVM data)
        {
            await repo.Add(data);
            return RedirectToAction("Index","NhaCungCap");
        }
        public IActionResult SuaNhaCungCap(int id)
        {
            var data = repo.Findata(id);
            AddorUpdateNhaCungCapVM olddata = new AddorUpdateNhaCungCapVM();
            olddata.Id = data.Id;
            olddata.TenNhaCungCap = data.TenNhaCungCap;
            olddata.SDT = data.SDT;
            olddata.Gmail = data.Gmail;
            olddata.DiaChi = data.DiaChi;
            return PartialView(olddata);
        }
        [HttpPost]
        public async  Task<IActionResult> SuaNhaCungCap(AddorUpdateNhaCungCapVM data)
        {
            try
            {
            await repo.Update(data);
            return Ok(true);
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex);
                return Ok(false);
            }
        }
        public async Task<IActionResult> XoaNhaCungCap(int id)
        {
            await repo.Detele(id);
            return Ok(true);
        }
    }
}
