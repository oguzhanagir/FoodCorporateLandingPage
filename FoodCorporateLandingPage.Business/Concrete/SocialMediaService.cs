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
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SocialMediaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(SocialMedia entity)
        {
            _unitOfWork.SocialMedias.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var socialMedia = _unitOfWork.SocialMedias.GetById(id);
            if (socialMedia != null)
            {
                _unitOfWork.SocialMedias.Remove(socialMedia);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<SocialMedia> GetAll()
        {
            return _unitOfWork.SocialMedias.GetAll();
        }

        public SocialMedia GetById(int id)
        {
            return _unitOfWork.SocialMedias.GetById(id);
        }

        public void Update(SocialMedia entity)
        {
            _unitOfWork.SocialMedias.Update(entity);
            _unitOfWork.Save();
        }
    }
}
