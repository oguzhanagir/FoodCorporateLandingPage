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
    public class HeaderBannerService : IHeaderBannerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HeaderBannerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(HeaderBanner entity)
        {
            _unitOfWork.HeaderBanners.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var headerBanner = _unitOfWork.HeaderBanners.GetById(id);
            if (headerBanner != null)
            {
                _unitOfWork.HeaderBanners.Remove(headerBanner);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<HeaderBanner> GetAll()
        {
            return _unitOfWork.HeaderBanners.GetAll();
        }

        public HeaderBanner GetById(int id)
        {
            return _unitOfWork.HeaderBanners.GetById(id);
        }

        public void Update(HeaderBanner entity)
        {
            _unitOfWork.HeaderBanners.Update(entity);
            _unitOfWork.Save();
        }
    }
}
