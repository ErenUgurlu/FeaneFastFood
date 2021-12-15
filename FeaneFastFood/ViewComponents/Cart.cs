using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.ViewComponents
{
    public class Cart : ViewComponent
    {
        readonly FoodManager foodManager = new(new EfFoodRepository());
        
        public IViewComponentResult Invoke()
        {
            return View(ViewBag.Data);
        }
    }
}
