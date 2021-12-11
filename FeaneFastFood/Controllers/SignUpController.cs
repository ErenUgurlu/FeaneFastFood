using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            UserValidator userValidator = new UserValidator();
            ValidationResult results = userValidator.Validate(user);
            if(results.IsValid)
            {
                
                user.Id = Guid.NewGuid();
                user.Authority = "Customer";
                um.Add(user);
                TempData["SuccessfulAdd"] = ("Welcome "+user.Name);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
