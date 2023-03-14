    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBanThuoc.Data.ViewModels;
using WebBanThuoc.DTOs;
using X.PagedList;

namespace WebBanThuoc.Data.Reponsitory.Admin
{
    public class NhaCungCapRepository:AdminRepository
    {
        public NhaCungCapRepository() : base() {  }
        public NhaCungCapRepository(WebBanThuocDbContext _db):base(_db)
        {
            
        }
        public X.PagedList.IPagedList<NhaCungCap> ListData( int page)
        {
            var data = db.nhaCungCaps.OrderByDescending(x => x.Id).ToPagedList(page,5);
            return data;
        }
        public async Task Add(AddorUpdateNhaCungCapVM data)
        {
            NhaCungCap adddata = new NhaCungCap();
            adddata.Id = data.Id;
            adddata.TenNhaCungCap = data.TenNhaCungCap;
            adddata.SDT = data.SDT;
            adddata.Gmail = data.Gmail;
            adddata.DiaChi = data.DiaChi;
            await db.nhaCungCaps.AddAsync(adddata);
            await this.Save();
        }
        public NhaCungCap Findata(int id)
        {
            var data = db.nhaCungCaps.Find(id);
            return data;
        }
        public async Task Update(AddorUpdateNhaCungCapVM data)
        {
            var olddata = Findata(data.Id);
            NhaCungCap adddata = new NhaCungCap();
            adddata.Id = data.Id;
            adddata.TenNhaCungCap = data.TenNhaCungCap;
            adddata.SDT = data.SDT;
            adddata.Gmail = data.Gmail;
            adddata.DiaChi = data.DiaChi;
            this.Copy<NhaCungCap>(adddata, olddata, "");
            await this.Save();
        }
        public async Task Detele(int id)
        {
            db.nhaCungCaps.Remove(Findata(id));
            await this.Save();
        }
    }
}
