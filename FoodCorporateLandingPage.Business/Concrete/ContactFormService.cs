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
    public class ContactFormService : IContactFormService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactFormService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(ContactForm entity)
        {
            _unitOfWork.ContactForms.Add(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var contactForm = _unitOfWork.ContactForms.GetById(id);
            if (contactForm != null)
            {
                _unitOfWork.ContactForms.Remove(contactForm);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<ContactForm> GetAll()
        {
            return _unitOfWork.ContactForms.GetAll();
        }

        public ContactForm GetById(int id)
        {
            return _unitOfWork.ContactForms.GetById(id);
        }

        public void Update(ContactForm entity)
        {
            _unitOfWork.ContactForms.Update(entity);
            _unitOfWork.Save();
        }
    }
}
