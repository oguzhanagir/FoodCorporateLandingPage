using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class MainAbout :ViewComponent
    {
        private readonly IAboutService _aboutService;

        public MainAbout(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var about = _aboutService.GetAll();
            return View(about);
        }
    }
}
