using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCorporateLandingPage.Business.Concrete
{
    public class BlogService : IBlogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Blog entity)
        {
            _unitOfWork.Blogs.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var blog = _unitOfWork.Blogs.GetById(id);
            if (blog != null)
            {
                _unitOfWork.Blogs.Remove(blog);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<Blog> GetAll()
        {
            return _unitOfWork.Blogs.GetAll();
        }

        public Blog GetById(int id)
        {
            return _unitOfWork.Blogs.GetById(id);
        }

        public void Update(Blog entity)
        {
            _unitOfWork.Blogs.Update(entity);
            _unitOfWork.Save();
        }
    }
}
