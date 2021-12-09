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
    public class CommentManager : ICommentService
    {
        readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal )
        {
            _commentDal = commentDal;
        }
        public void Add(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetListAll();
        }

        public Comment GetById(Guid id)
        {
            return _commentDal.GetById(id);
        }
    }
}
