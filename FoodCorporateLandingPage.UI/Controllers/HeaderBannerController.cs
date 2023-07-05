using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class HeaderBannerController : Controller
    {
        private readonly IHeaderBannerService _headerBannerService;

        public HeaderBannerController(IHeaderBannerService headerBannerService)
        {
            _headerBannerService = headerBannerService;
        }
        public IActionResult AdminHeaderBannerList()
        {
            var headerBanners = _headerBannerService.GetAll();
            return View(headerBanners);
        }

        [HttpGet]
        public IActionResult AddHeaderBanner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHeaderBanner(HeaderBanner headerBanner)
        {
            _headerBannerService.Create(headerBanner);
            return RedirectToAction("AdminHeaderBannerList", "HeaderBanner");
        }

        [HttpGet]
        public IActionResult UpdateHeaderBanner(int id)
        {
            var headerBanner = _headerBannerService.GetById(id);
            return View(headerBanner);
        }

        [HttpPost]
        public IActionResult UpdateHeaderBanner(HeaderBanner headerBanner)
        {
            _headerBannerService.Update(headerBanner);
            return RedirectToAction("AdminHeaderBannerList", "HeaderBanner");
        }


        public IActionResult DeleteHeaderBanner(int id)
        {
            _headerBannerService.Delete(id);
            return RedirectToAction("AdminHeaderBannerList","HeaderBanner");
        }

    }
}
