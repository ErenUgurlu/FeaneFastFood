using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FeaneFastFood.ViewComponents
{
    public class Comments : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CommentManager commentManager = new CommentManager(new EfCommentRepository());
            var comments = commentManager.GetAll();
            return View(comments);
        }
    }
}
