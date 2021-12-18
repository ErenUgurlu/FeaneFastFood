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
    public class DiscountManager : IDiscountService
    {
        readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void Add(Discount discount)
        {
            _discountDal.Insert(discount);
        }

        public void Delete(Discount discount)
        {
            _discountDal.Delete(discount);
        }

        public void Update(Discount discount)
        {
            _discountDal.Update(discount);
        }

        public List<Discount> GetAll()
        {
            return _discountDal.GetListAll();
        }

        public Discount GetById(Guid id)
        {
            return _discountDal.GetById(id);
        }
    }
}
