using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class ItemsMenuArea: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
