using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.ViewComponents
{
    public class Discounts : ViewComponent
    {
        readonly DiscountManager discountManager = new(new EfDiscountRepository());    
        public IViewComponentResult Invoke()
        {
            var discounts = discountManager.GetAll();      
            return View(discounts);
        }
    }
}
