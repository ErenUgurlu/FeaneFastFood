using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Controllers
{
    public class AboutController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            ViewBag.about = "active";
            return View();
        }
    }
}
