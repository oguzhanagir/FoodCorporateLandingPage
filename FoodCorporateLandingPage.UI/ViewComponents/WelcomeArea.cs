using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class WelcomeArea: ViewComponent
    {
        private readonly IHeaderBannerService _headerBannerService;

        public WelcomeArea(IHeaderBannerService headerBannerService)
        {
            _headerBannerService = headerBannerService;
        }
        public IViewComponentResult Invoke()
        {
            var headerList = _headerBannerService.GetAll();
            return View(headerList);
        }
    }
}
