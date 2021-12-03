using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FoodManager : IFoodService
    {
        readonly IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void Add(Food food)
        {
            _foodDal.Insert(food);
        }

        public void Delete(Food food)
        {
            _foodDal.Delete(food);
        }

        public void Update(Food food)
        {
            _foodDal.Update(food);
        }

        public List<Food> GetAll()
        {
            return _foodDal.GetListAll();
        }

        public Food GetById(Guid id)
        {
            return _foodDal.GetById(id);
        }

        public List<Food> GetAllWithCategory()
        {
            return _foodDal.GetListWithCategory();
        }
    }
}
