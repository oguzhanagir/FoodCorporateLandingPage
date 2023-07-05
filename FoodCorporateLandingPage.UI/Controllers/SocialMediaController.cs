using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult AdminSocialMediaList()
        {
            var socialMediaList = _socialMediaService.GetAll();
            return View(socialMediaList);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.Create(socialMedia);
            return RedirectToAction("AdminSocialMediaList","SocialMedia");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var socialMedia = _socialMediaService.GetById(id);
            return View(socialMedia);
        }


        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.Update(socialMedia);
            return RedirectToAction("AdminSocialMediaList", "SocialMedia");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            _socialMediaService.Delete(id);
            return RedirectToAction("AdminSocialMediaList", "SocialMedia");
        }
    }
}
