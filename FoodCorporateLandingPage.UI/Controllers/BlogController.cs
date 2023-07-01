using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails(int id)
        {
            var blog = _blogService.GetById(id);
            return View(blog);
        }


        public IActionResult AdminBlogList()
        {
            var blogList = _blogService.GetAll();
            return View(blogList);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            _blogService.Create(blog);
            return RedirectToAction("AdminBlogList", "Blog");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var blog = _blogService.GetById(id);
            return View(blog);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            _blogService.Update(blog);
            return RedirectToAction("AdminBlogList", "Blog");
        }

        public IActionResult DeleteBlog(int id)
        {
            _blogService.Delete(id);
            return RedirectToAction("AdminBlogList", "Blog");
        }



    }
}
