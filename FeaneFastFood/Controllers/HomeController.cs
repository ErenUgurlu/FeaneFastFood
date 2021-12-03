using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using FeaneFastFood.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Controllers
{
    public class HomeController : Controller
    {
        readonly FoodManager foodManager = new(new EfFoodRepository());
        public IActionResult Index()
        {
            var foods = foodManager.GetAllWithCategory();
            return View(foods);
        }
    }
}
