using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBanThuoc.Data;

namespace WebBanThuoc.Web.Areas.Admin.ViewComponents
{
    public class LIstNCCViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int? seletetedId)
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            ViewBag.SelectedId = seletetedId;
            var data = await db.nhaCungCaps.ToListAsync();
            return View(data);
        }
    }
}
