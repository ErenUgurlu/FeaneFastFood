using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FeaneFastFood.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.ViewComponents
{
    public class Cart : ViewComponent
    {   
        public IViewComponentResult Invoke()
        {
            OrderAndFoodListVM orderAndFood = new()
            {
                Foods = ViewBag.Data,
                Order = new Order()
            };
            return View(orderAndFood);
        }
    }
}
