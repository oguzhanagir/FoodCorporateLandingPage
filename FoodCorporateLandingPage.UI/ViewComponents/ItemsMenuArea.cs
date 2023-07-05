using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class ItemsMenuArea: ViewComponent
    {
        private readonly IServiceService _serviceService;

        public ItemsMenuArea(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            var serviceList = _serviceService.GetAll();
            return View(serviceList);
        }
    }
}
