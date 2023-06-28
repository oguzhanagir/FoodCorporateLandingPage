using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class Footer: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
