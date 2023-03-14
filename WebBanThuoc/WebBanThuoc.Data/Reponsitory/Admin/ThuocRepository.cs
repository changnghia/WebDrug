using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBanThuoc.Data.ViewModels.Thuoc;
using WebBanThuoc.DTOs;
using X.PagedList;

namespace WebBanThuoc.Data.Reponsitory.Admin
{
    public class ThuocRepository:AdminRepository
    {
        public ThuocRepository() : base() { }
        public ThuocRepository(WebBanThuocDbContext _db) : base(_db) { }
        public X.PagedList.IPagedList<ListThuocVM> ListData(int page)
        {
            var data = db.thuocs.Select(model=>new ListThuocVM{ 
                Id=model.Id,
                TenThuoc=model.TenThuoc,
                CongDung=model.CongDung,
                DVT=model.DVT,
                GiaTien=model.GiaTien,
                SoLuong=model.SoLuong,
                DaBan=model.DaBan,
                NhaCungCap=model.nhaCungCap.TenNhaCungCap,
                LoaiThuoc=model.phanLoaiThuoc.LoaiThuoc,
                TaiKhoan=model.taiKhoan.UserName
            }).OrderByDescending(x => x.Id).ToPagedList(page, 5);
            return data;
        }
        public async Task AddThoc(AddEditThuocVM data)
        {
            Thuoc model = new Thuoc();
            model.TenThuoc = data.TenThuoc;
            model.CongDung = data.CongDung;
            model.DVT = data.DVT;
            model.GiaTien = data.GiaTien;
            model.SoLuong = data.SoLuong;
            model.DaBan = 0;
            model.IdLoaiThuoc = data.IdLoaiThuoc;
            model.IdNhaCungCap = data.IdNhaCungCap;
            model.IdTaiKhoan = data.IdTaiKhoan;
            model.duongdan = data.duongdan;
            await db.AddAsync(model);
            await this.Save();
        }
        public Thuoc FindThuoc(int id)
        {
            var data = db.thuocs.Find(id);
            return data;
        }
        public AddEditThuocVM EpVM(Thuoc data)
        {
            AddEditThuocVM model = new AddEditThuocVM();
            model.TenThuoc = data.TenThuoc;
            model.CongDung = data.CongDung;
            model.DVT = data.DVT;
            model.GiaTien = data.GiaTien;
            model.SoLuong = data.SoLuong;
            model.DaBan = 0;
            model.IdLoaiThuoc = data.IdLoaiThuoc;
            model.IdNhaCungCap = data.IdNhaCungCap;
            model.IdTaiKhoan = data.IdTaiKhoan;
            model.duongdan = data.duongdan;
            return model;
        }
        public void EditThuoc(AddEditThuocVM data)
        {
            var olddata = FindThuoc(data.Id);
            Thuoc model = new Thuoc();
            model.Id = data.Id;
            model.TenThuoc = data.TenThuoc;
            model.CongDung = data.CongDung;
            model.DVT = data.DVT;
            model.GiaTien = data.GiaTien;
            model.SoLuong = data.SoLuong;
            model.DaBan = 0;
            model.IdLoaiThuoc = data.IdLoaiThuoc;
            model.IdNhaCungCap = data.IdNhaCungCap;
            model.IdTaiKhoan = data.IdTaiKhoan;
            model.duongdan = data.duongdan;
            this.Copy<Thuoc>(model, olddata, "");
            db.SaveChanges();
        }
        public async Task Delete(int id)
        {
            db.thuocs.Remove(FindThuoc(id));
            await this.Save();
        }
    }
}
