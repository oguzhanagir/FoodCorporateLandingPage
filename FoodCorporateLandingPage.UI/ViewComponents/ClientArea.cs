using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class ClientArea:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
