using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebBanThuoc.Data.Reponsitory.Admin;
using WebBanThuoc.Data.ViewModels.User;

namespace WebBanThuoc.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class UserController : Controller
    {
        UserRepository repo;
        public UserController()
        {
            repo = new UserRepository();
        }
        public IActionResult SignUp()=>View();
        [HttpPost]
        public async Task<IActionResult> SignUp(AddUserVM addUserVM)
        {
            try
            {
                await repo.SingUp(addUserVM);
                return Ok(true);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Ok();
            }
        }
        public IActionResult CheckUser(string username)
        {
            var data=repo.CheckUser(username);
            if (data!=null)
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }

        }
        public IActionResult Login() => PartialView();
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            model.UserName = model.UserName.Replace(" ", "").ToLower();
            var user = repo.AsNo(model.UserName);
            if (user != null)
            {
                HMACSHA512 hmac = new HMACSHA512();
                hmac.Key = user.PassworkSalt;
                var pwByte = Encoding.UTF8.GetBytes(model.Password);
                var pwHash = hmac.ComputeHash(pwByte);
                if (pwHash.SequenceEqual(user.PassworkHash))
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName),
                        new Claim(ClaimTypes.GivenName,user.HoTen),
                        new Claim(ClaimTypes.Role,user.IsAdmin ?"Admin":"Member")
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                    var principal = new ClaimsPrincipal(claimsIdentity);
                    var authProperty = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddHours(6),
                        IsPersistent = model.Check
                    };
                    await HttpContext.SignInAsync("Cookies", principal, authProperty);
                    if (user.IsAdmin)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
                }
            }
            else
            {

            }
            return RedirectToAction(nameof(Login));
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
