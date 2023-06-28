using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class OfferArea : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
