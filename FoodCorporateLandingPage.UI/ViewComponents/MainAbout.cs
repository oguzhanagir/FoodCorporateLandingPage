using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class MainAbout :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
