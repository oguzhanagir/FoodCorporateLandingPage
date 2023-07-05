using FoodCorporateLandingPage.Business.Concrete;
using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodCorporateLandingPage.UI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }


        public IActionResult AdminServiceList()
        {
            var serviceList = _serviceService.GetAll();
            return View(serviceList);
        }


        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(Service service, IFormFile file)
        {
            if (service != null)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = "images/service/" + fileName;

                    using (var stream = new FileStream(Path.Combine("wwwroot", filePath), FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    service.ImagePath = filePath;
                }
                else
                {
                    var findAbout = _serviceService.GetById(service.Id);
                    service.ImagePath = findAbout.ImagePath;

                }
                
            _serviceService.Create(service);
            }
            return RedirectToAction("AdminServiceList","Service");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var service = _serviceService.GetById(id);
            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateService(Service service, IFormFile file)
        {
            if (service != null)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = "images/service/" + fileName;

                    using (var stream = new FileStream(Path.Combine("wwwroot", filePath), FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    service.ImagePath = filePath;
                }
                else
                {
                    var findAbout = _serviceService.GetById(service.Id);
                    service.ImagePath = findAbout.ImagePath;

                }

                _serviceService.Update(service);
            }
            return RedirectToAction("AdminServiceList", "Service");
        }

        public IActionResult DeleteService(int id)
        {
            _serviceService.Delete(id);
            return RedirectToAction("AdminServiceList", "Service");
        }

    }
}
