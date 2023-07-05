using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class Footer: ViewComponent
    {
        private readonly IContactService _contactService;

        public Footer(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var contactInfo = _contactService.GetAll();
            return View(contactInfo);
        }
    }
}
