using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class VideoArea : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
