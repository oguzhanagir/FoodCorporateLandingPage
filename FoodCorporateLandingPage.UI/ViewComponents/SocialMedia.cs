using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class SocialMedia : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IContactService _contactService;

        public SocialMedia(ISocialMediaService socialMediaService,IContactService contactService)
        {
            _socialMediaService = socialMediaService;
            _contactService = contactService;
        }
        public IViewComponentResult Invoke()
        {
            var socialMedias = _socialMediaService.GetAll();
            ViewBag.PhoneNumber = _contactService.GetPhoneNumber();

            return View(socialMedias);
        }
    }
}
