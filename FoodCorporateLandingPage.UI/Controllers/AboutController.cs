using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var about = _aboutService.GetAll();
            return View(about);
        }

        public IActionResult AdminAboutList()
        {
            var aboutList = _aboutService.GetAll();
            return View(aboutList);
        }


        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.Update(about);
            return RedirectToAction("AdminAboutList","About");
        }
    }
}
