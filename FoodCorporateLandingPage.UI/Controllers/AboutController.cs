using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var about = _aboutService.GetAll();
            return View(about);
        }

        public IActionResult AdminAboutList()
        {
            var aboutList = _aboutService.GetAll();
            return View(aboutList);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var about = _aboutService.GetById(id);
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(About about, IFormFile file)
        {
            if (about != null)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = "images/about/" + fileName;

                    using (var stream = new FileStream(Path.Combine("wwwroot", filePath), FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    about.ImagePath = filePath;
                }
                else
                {
                    var findAbout = _aboutService.GetById(about.Id);
                    about.ImagePath = findAbout.ImagePath;

                }
                _aboutService.Update(about);
            }
            return RedirectToAction("AdminAboutList","About");
        }
    }
}
