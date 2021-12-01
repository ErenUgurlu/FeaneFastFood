using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        public void Add(Category category)
        {
            context.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category category)
        {
            context.Remove(category);
        }

        public Category GetById(Guid id)
        {
            return context.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return context.Categories.ToList();
        }

        public void Update(Category category)
        {
            context.Update(category);
            context.SaveChanges();
        }
    }
}
