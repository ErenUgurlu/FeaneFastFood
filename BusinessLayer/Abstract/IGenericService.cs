using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        public void Add(T t);
        public void Delete(T t);
        public void Update(T t);
        public List<T> GetAll();
        public T GetById(Guid id);

    }
}
