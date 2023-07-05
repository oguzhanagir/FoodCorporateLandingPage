using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class ClientArea:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public ClientArea(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var aboutList = _aboutService.GetAll();
            return View(aboutList);
        }


    }
}
