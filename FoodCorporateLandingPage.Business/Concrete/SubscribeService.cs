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
    public class SubscribeService : ISubscribeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubscribeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Subscribe entity)
        {
            _unitOfWork.Subscribes.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var subscribe = _unitOfWork.Subscribes.GetById(id);
            if (subscribe != null)
            {
                _unitOfWork.Subscribes.Remove(subscribe);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<Subscribe> GetAll()
        {
            return _unitOfWork.Subscribes.GetAll();
        }

        public Subscribe GetById(int id)
        {
            return _unitOfWork.Subscribes.GetById(id);
        }

        public void Update(Subscribe entity)
        {
            _unitOfWork.Subscribes.Update(entity);
            _unitOfWork.Save();
        }
    }
}
