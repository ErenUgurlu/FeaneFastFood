using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FeaneFastFood.Models;
using FeaneFastFood.ViewModels;
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
        static readonly List<Food> orders = new();


        public IActionResult Index(Guid foodInCart)
        {
            
            ViewBag.home = "active";
            var foods = foodManager.GetAllWithCategory();
            if(foodInCart != Guid.Empty)
            {

                if (orders.Find(x => x.Id == foodInCart) == null)
                {
                    orders.Add(foodManager.GetById(foodInCart));
                }
                else
                {
                    orders.Find(x => x.Id == foodInCart).InCartQuantity += 1;
                }
                    
                
            }
            ViewBag.Data = orders;
            if (foodInCart != Guid.Empty)
            {
                return RedirectToAction("Index", "Home");

            }

            return View(foods);
        }



    }
}
