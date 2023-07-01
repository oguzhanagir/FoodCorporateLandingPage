using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class BlogGrids : ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogGrids(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var blogList = _blogService.GetAll();
            return View(blogList);
        }
    }
}
