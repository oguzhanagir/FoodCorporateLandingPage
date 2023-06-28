using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class Header:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
