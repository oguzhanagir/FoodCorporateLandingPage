using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class AppsArea:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
