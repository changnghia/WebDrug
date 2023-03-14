using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThuoc.Data;

namespace WebBanThuoc.Web.Areas.Admin.ViewComponents
{
    public class ListPLTViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int? seletetedId)
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            ViewBag.SelectedId = seletetedId;
            var data = await db.phanLoaiThuocs.ToListAsync();
            return View(data);
        }
    }
}
