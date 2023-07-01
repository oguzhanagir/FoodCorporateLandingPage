using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly IContactFormService _contactFormService;

        public ContactFormController(IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
        }

        [HttpPost]
        public IActionResult AddContactForm(ContactForm contactForm)
        {
            _contactFormService.Create(contactForm);
            return RedirectToAction("Index","Contact");
        }
    }
}
