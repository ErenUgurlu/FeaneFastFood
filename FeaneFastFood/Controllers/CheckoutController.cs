using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FeaneFastFood.ViewModels;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Controllers
{
    public class CheckoutController : Controller
    {
        readonly OrderManager orderManager = new(new EfOrderRepository());
        readonly DiscountManager discountManager = new(new EfDiscountRepository());
        readonly OrderDetailManager orderDetailManager = new(new EfOrderDetailRepository());
        [HttpPost]
        public IActionResult Index(OrderAndFoodListVM viewModel)
        {
            viewModel.Order = new();
            List<Discount> DiscountList = discountManager.GetAll();
            foreach (var item in DiscountList)
            {
                if(DateTime.Now < item.Finish && DateTime.Now > item.Start)
                {
                    if (item.MinPrice < viewModel.Foods.Sum(x => x.Price * x.InCartQuantity))
                    {
                        viewModel.Order.Discount = item;
                        viewModel.Order.DiscountId = item.Id;
                    }
                    
                }
            }
            if (viewModel.Foods.Sum(x => x.Price * x.InCartQuantity) >= 100)
            {
                viewModel.Order.ShipmentPrice = 0;
            }
            else
            {
                viewModel.Order.ShipmentPrice = 10;
            }
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult CreateOrder(OrderAndFoodListVM viewModel)
        {
            
            OrderValidator validations = new();
            ValidationResult results = validations.Validate(viewModel.Order);
            if (results.IsValid)
            {
                viewModel.Order.Id = Guid.NewGuid();
                double totalprice = 0;
                var shipmentPrice = 10;
                foreach (var item in viewModel.Foods)
                {
                    totalprice += item.Price * item.InCartQuantity;
                }
                if (totalprice > 100)
                {
                    shipmentPrice = 0;
                }
                totalprice = ((totalprice / 100) * (100 - viewModel.Order.Discount.DiscountRate));
                viewModel.Order.TotalPrice = ((int)totalprice);
                viewModel.Order.ShipmentPrice = shipmentPrice;
                viewModel.Order.OrderDate = DateTime.Now;
                viewModel.Order.UserId = Guid.Parse("A81F3986-8368-4C58-B4C4-85210E0564B1");
                double reducedPrice = (double)viewModel.Order.Discount.DiscountRate;
                var a = viewModel.Order.DiscountId;
                viewModel.Order.Discount = null;
                
                
                orderManager.Add(viewModel.Order);
                foreach (var item in viewModel.Foods)
                {
                    OrderDetail orderDetail = new();
                    orderDetail.Id = Guid.NewGuid();
                    orderDetail.FoodId = item.Id;
                    orderDetail.OrderId = viewModel.Order.Id;

                    orderDetail.ReducedPrice = ((int)((double)item.Price/100*(100.00-reducedPrice))); 
                    orderDetailManager.Add(orderDetail);

                }
                
                
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
