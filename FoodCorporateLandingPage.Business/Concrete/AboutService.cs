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
    public class AboutService: IAboutService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AboutService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(About entity)
        {
            _unitOfWork.Abouts.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var about = _unitOfWork.Abouts.GetById(id);
            if (about != null)
            {
                _unitOfWork.Abouts.Remove(about);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<About> GetAll()
        {
            return _unitOfWork.Abouts.GetAll();
        }

        public About GetById(int id)
        {
            return _unitOfWork.Abouts.GetById(id);
        }

        public void Update(About entity)
        {
            _unitOfWork.Abouts.Update(entity);
            _unitOfWork.Save();
        }
    }
}
