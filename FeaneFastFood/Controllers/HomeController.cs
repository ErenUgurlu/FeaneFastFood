using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FeaneFastFood.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FeaneFastFood.Controllers
{
    public class HomeController : Controller
    {
        readonly FoodManager foodManager = new(new EfFoodRepository());
        public IActionResult Index()
        {
            ViewBag.home = "active";
            var foods = foodManager.GetAllWithCategory();
            return View(foods);
        }
        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            Context c = new Context();
            var datavalue = c.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if (datavalue != null)
            {
                var claims = new List<Claim>
               {
                   new Claim(ClaimTypes.Name,user.Email)
               };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
