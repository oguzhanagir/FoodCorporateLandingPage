using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public IActionResult AdminSubscribeList()
        {
            var subscribeList  = _subscribeService.GetAll();
            return View(subscribeList);
        }

        [HttpPost]
        public void AddSubsribe(Subscribe subscribe)
        {
            _subscribeService.Create(subscribe);
        }

        public IActionResult DeleteSubscribe(int id)
        {
            _subscribeService.Delete(id);
            return RedirectToAction("AdminSubscribeList","Subscribe");
        }
    }
}
