using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IFoodService
    {
        void Add(Food food);
        void Update(Food food);
        void Delete(Food food);
        List<Food> GetAll();
        List<Food> GetAllWithCategory();
        Food GetById(Guid id);
    }
}
