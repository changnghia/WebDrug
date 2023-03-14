using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebBanThuoc.Data.ViewModels.User;
using WebBanThuoc.DTOs;

namespace WebBanThuoc.Data.Reponsitory.Admin
{
    public class UserRepository:AdminRepository
    {
        public UserRepository() : base() { }
        public UserRepository(WebBanThuocDbContext _db) : base(_db) { }
		public TaiKhoan CheckUser(string username)
        {
			var data = db.taiKhoans.Where(x => x.UserName == username).FirstOrDefault();
			return data;
        }
        public async Task SingUp(AddUserVM addUserVM)
        {
            TaiKhoan user = new TaiKhoan();
            try
            {
                HMACSHA512 hmac = new HMACSHA512();
                var pwByte = Encoding.UTF8.GetBytes(addUserVM.Password);
                user.PassworkHash = hmac.ComputeHash(pwByte);
                user.PassworkSalt = hmac.Key;

                user.UserName = addUserVM.UserName.Replace(" ", "").ToLower();
                user.HoTen = addUserVM.HoTen;
                user.IsAdmin = addUserVM.IsAdmin;
                await db.taiKhoans.AddAsync(user);
                await this.Save();
            }
            catch
            {

            }
        }
        public TaiKhoan AsNo(string username)
        {
            return db.taiKhoans.AsNoTracking().SingleOrDefault(u=>u.UserName==username);
        }
    }
}
