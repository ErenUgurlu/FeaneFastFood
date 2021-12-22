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
    public class UserManager : IUserService
    {
        readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(ApplicationUser user)
        {
            _userDal.Insert(user);
        }

        public void Delete(ApplicationUser user)
        {
            _userDal.Delete(user);
        }

        public List<ApplicationUser> GetAll()
        {
            return _userDal.GetListAll();
        }

        public ApplicationUser GetById(Guid id)
        {
            return _userDal.GetById(id);
        }

        public void Update(ApplicationUser user)
        {
            _userDal.Update(user);
        }
    }
}
