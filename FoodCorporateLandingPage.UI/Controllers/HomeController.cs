using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
    }
}