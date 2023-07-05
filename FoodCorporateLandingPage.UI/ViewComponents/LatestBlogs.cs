using FoodCorporateLandingPage.Core.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.ViewComponents
{
    public class LatestBlogs : ViewComponent
    {
        private readonly IBlogService _blogService;

        public LatestBlogs(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var latestBlog = _blogService.GetAll();
            return View(latestBlog); 
        }
    }
}
