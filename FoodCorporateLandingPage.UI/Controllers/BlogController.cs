using FoodCorporateLandingPage.Business.Concrete;
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
        public async Task<IActionResult> AddBlog(Blog blog, IFormFile file)
        {
            if (blog != null)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = "images/blog/" + fileName;

                    using (var stream = new FileStream(Path.Combine("wwwroot", filePath), FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    blog.ImagePath = filePath;
                }
                else
                {
                    var findBlog = _blogService.GetById(blog.Id);
                    blog.ImagePath = findBlog.ImagePath;
                }
                _blogService.Create(blog);
            }
            return RedirectToAction("AdminBlogList", "Blog");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var blog = _blogService.GetById(id);
            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(Blog blog, IFormFile file)
        {
            if (blog != null)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = "images/blog/" + fileName;

                    using (var stream = new FileStream(Path.Combine("wwwroot", filePath), FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    blog.ImagePath = filePath;
                }
                else
                {
                    var findBlog = _blogService.GetById(blog.Id);
                    blog.ImagePath = findBlog.ImagePath;
                }
                _blogService.Update(blog);
            }
            return RedirectToAction("AdminBlogList", "Blog");
        }

        public IActionResult DeleteBlog(int id)
        {
            _blogService.Delete(id);
            return RedirectToAction("AdminBlogList", "Blog");
        }



    }
}
