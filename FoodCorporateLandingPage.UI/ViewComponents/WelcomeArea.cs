﻿using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class WelcomeArea: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}