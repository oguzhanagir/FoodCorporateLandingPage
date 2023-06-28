using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class SubscribeArea : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
