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
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Service entity)
        {
            _unitOfWork.Services.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var service = _unitOfWork.Services.GetById(id);
            if (service != null)
            {
                _unitOfWork.Services.Remove(service);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<Service> GetAll()
        {
            return _unitOfWork.Services.GetAll();
        }

        public Service GetById(int id)
        {
            return _unitOfWork.Services.GetById(id);
        }

        public void Update(Service entity)
        {
            _unitOfWork.Services.Update(entity);
            _unitOfWork.Save();
        }
    }
}
