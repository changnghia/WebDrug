using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBanThuoc.Data.ViewModels.PhanLoaiThuoc;
using WebBanThuoc.DTOs;
using X.PagedList;

namespace WebBanThuoc.Data.Reponsitory.Admin
{
    public class PhanLoaiThuocRepository :AdminRepository
    {
        public PhanLoaiThuocRepository() : base() { }
        public PhanLoaiThuocRepository(WebBanThuocDbContext _db) : base(_db) { }
        public X.PagedList.IPagedList<PhanLoaiThuoc> ListData(int page)
        {
            var data = db.phanLoaiThuocs.OrderByDescending(x => x.Id).ToPagedList(page, 5);
            return data;
        }
        public async Task Add(PhanLoaiThuocVM data)
        {
            PhanLoaiThuoc add = new PhanLoaiThuoc();
            add.Id = data.Id;
            add.LoaiThuoc = data.LoaiThuoc;
            await db.AddAsync(add);
            await this.Save();
        }
        public PhanLoaiThuoc Find(int id)
        {
            var data = db.phanLoaiThuocs.Find(id);
            return data;
        }
        public async Task Update(PhanLoaiThuocVM data)
        {
            var olddata = Find(data.Id);
            PhanLoaiThuoc updatedata = new PhanLoaiThuoc();
            updatedata.Id = data.Id;
            updatedata.LoaiThuoc = data.LoaiThuoc;
            this.Copy<PhanLoaiThuoc>(updatedata, olddata, "");
            await this.Save();
        }
        public async Task Delete(int id)
        {
            db.phanLoaiThuocs.Remove(Find(id));
            await this.Save();
        }
    }
}
