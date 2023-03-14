using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThuoc.Data.Reponsitory.Admin;
using WebBanThuoc.Data.ViewModels.PhanLoaiThuoc;
using WebBanThuoc.DTOs;

namespace WebBanThuoc.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class PhanLoaiThuocController : Controller
    {
        PhanLoaiThuocRepository repo;
        public PhanLoaiThuocController()
        {
            repo = new PhanLoaiThuocRepository();
        }
        public IActionResult Index(int page=1)
        {
            var data =repo.ListData(page);
            return View(data);
        }
        public IActionResult lisdata(int page = 1)
        {
            var data = repo.ListData(page);
            return PartialView(data);
        }
        public IActionResult AddPLT()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddPLT(PhanLoaiThuocVM data)
        {
            await repo.Add(data);
            return Ok(true);
        }
        public IActionResult Update(int id)
        {
            var data = repo.Find(id);
            PhanLoaiThuocVM model = new PhanLoaiThuocVM();
            model.Id = data.Id;
            model.LoaiThuoc = data.LoaiThuoc;
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(PhanLoaiThuocVM data)
        {
            try
            {
            await repo.Update(data);
            return Ok(true);
            }catch(Exception ex)
            {
                return Ok(false);
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            await repo.Delete(id);
            return Ok(true);
        }

    }
}
