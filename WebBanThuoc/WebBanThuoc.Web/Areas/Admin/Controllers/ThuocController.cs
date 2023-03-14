
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBanThuoc.Data.Reponsitory.Admin;
using WebBanThuoc.Data.ViewModels.Thuoc;

namespace WebBanThuoc.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ThuocController : Controller
    {
        ThuocRepository repo;
        private IWebHostEnvironment Host;
        public ThuocController(IWebHostEnvironment _Host)
        {
            repo = new ThuocRepository();
            Host = _Host;
        }
        string UploadImgAndReturnPath(IFormFile file, string childFolder = "/img/", bool saveInWwwRoot = true)
		{
            var y = Host.WebRootPath;
			var root = saveInWwwRoot ? Host.WebRootPath : Host.ContentRootPath;
			var filename = Path.GetFileNameWithoutExtension(file.FileName)
							+ DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss-fff")
							+ Path.GetExtension(file.FileName);
			if (!Directory.Exists(root + childFolder))
			{
				Directory.CreateDirectory(root + childFolder);
			}
			var relativePath = childFolder + filename;
			var path = root + relativePath;
			var x = new FileStream(path, FileMode.Create);
			file.CopyTo(x);
			x.Dispose();
			GC.Collect();
			return relativePath;
		}
        public IActionResult Index(int page=1)
        {
            var data = repo.ListData(page);
            return View(data);
        }
        public IActionResult Listdata(int page = 1)
        {
            var data = repo.ListData(page);
            return PartialView(data);
        }
        public IActionResult AddThuoc()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddThuoc(AddEditThuocVM data)
        {
            if (data.Hinh != null)
            {
                string image = UploadImgAndReturnPath(data.Hinh, "/img/thuoc");
                image = image.Split('/').Last();
                data.duongdan = image;
            }
            data.IdTaiKhoan =Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            await repo.AddThoc(data);
            return RedirectToAction("Index", "Thuoc");
        }
        public IActionResult EditThuoc(int id)
        {
            var data = repo.EpVM(repo.FindThuoc(id));

            return View(data);
        }
        [HttpPost]
        public IActionResult EditThuoc(AddEditThuocVM data)
        {            
            repo.EditThuoc(data);
            return Ok(true);
        }
        public async Task<IActionResult> DeleteThuoc(int id)
        {
            await repo.Delete(id);
            return Ok(true);
        }
    }
}
