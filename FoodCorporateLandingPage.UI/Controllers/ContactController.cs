using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
   
        public IActionResult AdminContactList()
        {
            var contactInfo = _contactService.GetAll();
            return View(contactInfo);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactService.Update(contact);
            return RedirectToAction("AdminContactList", "Contact");
        }


    }
}
