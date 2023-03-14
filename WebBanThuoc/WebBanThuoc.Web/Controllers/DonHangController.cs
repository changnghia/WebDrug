using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBanThuoc.Data;
using WebBanThuoc.Data.ViewModels.DatHang;
using WebBanThuoc.DTOs;
using X.PagedList;

namespace WebBanThuoc.Web.Controllers
{
    public class DonHangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult DatHang()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult>DatHang(DatHangVM data)
        {
            WebBanThuocDbContext db=new WebBanThuocDbContext();
            DonHang donHang = new DonHang();
            donHang.TenKH = data.TenKH;
            donHang.DiaChi = data.DiaChi;
            donHang.SDT = data.SDT;
            donHang.ngaydat = data.ThoiGianDatHang;
            donHang.IdTaiKhoan = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var cookieList = Request.Cookies.Where(x => x.Key.Contains("products_"))
               .ToList();
            List<ChiTietDonHang> chiTietDonDatHangList = new List<ChiTietDonHang>();
            foreach (var item in cookieList)
            {
                try
                {
                    int currentID = Convert.ToInt32(item.Key.Replace("products_", ""));
                    Thuoc thisProduct = db.thuocs.Find(currentID);
                    ChiTietDonHang chiTietDonDatHang = new ChiTietDonHang()
                    {
                        IdThuoc = currentID,
                        SoLuong = Convert.ToInt32(item.Value)
                    };
                    thisProduct.DaBan = thisProduct.DaBan+ chiTietDonDatHang.SoLuong;
                    db.thuocs.Update(thisProduct);
                    chiTietDonDatHang.Gia = thisProduct.GiaTien * chiTietDonDatHang.SoLuong;
                    chiTietDonDatHangList.Add(chiTietDonDatHang);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    continue;
                }
            }
            donHang.chiTietDonHangs = chiTietDonDatHangList;
            double tamTinh = 0;
            foreach (var item in donHang.chiTietDonHangs)
            {
                tamTinh += item.Gia;
            }
            donHang.TongSoTien = Convert.ToInt32(tamTinh);
            await db.AddAsync(donHang);
            await db.SaveChangesAsync();
            return Ok(true);
            }
        public IActionResult ListCartofUser(int page = 1)
        {
            WebBanThuocDbContext db = new WebBanThuocDbContext();
            var idUser = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var data = db.donHangs
               .Where(x => x.IdTaiKhoan == idUser)
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

    }
}
