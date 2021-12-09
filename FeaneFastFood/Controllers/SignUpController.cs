using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Controllers
{
    public class SignUpController : Controller
    {
        UserManager um = new(new EfUserRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            user.Id = Guid.NewGuid();
            user.Authority = "Customer";
            um.Add(user);
            return RedirectToAction("Index","Home");
        }
    }
}
