using Basecode.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;

namespace Basecode.WebApp.Controllers
{
    public class JobOpeningController : Controller
    {
        private readonly JobOpeningService _service;

        public JobOpeningController(IJobOpeningService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.RetrieveAll();
            return View(data);
        }

        [HttpPost]
        public IActionResult Add(JobOpening jobOpening)
        {
            _service.Add(jobOpening);
            return RedirectToAction("Index");
        }
    }
}