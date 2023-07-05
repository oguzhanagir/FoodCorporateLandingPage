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
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Contact entity)
        {
            _unitOfWork.Contacts.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var contact = _unitOfWork.Contacts.GetById(id);
            if (contact != null)
            {
                _unitOfWork.Contacts.Remove(contact);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<Contact> GetAll()
        {
            return _unitOfWork.Contacts.GetAll();
        }

        public Contact GetById(int id)
        {
            return _unitOfWork.Contacts.GetById(id);
        }

        public void Update(Contact entity)
        {
            _unitOfWork.Contacts.Update(entity);
            _unitOfWork.Save();
        }

        public string GetPhoneNumber()
        {
            var phoneNo = _unitOfWork.Contacts.GetPhoneNumber();
            return phoneNo;
        }
    }
}
