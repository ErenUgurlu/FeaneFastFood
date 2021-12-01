using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);
        List<Category> GetAll();
        Category GetById(Guid id);
    }
}
