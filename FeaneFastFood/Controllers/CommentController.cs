using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.comment = "active";
            return View();
        }
    }
}
