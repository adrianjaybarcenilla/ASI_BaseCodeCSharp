using Basecode.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers{
    public class JobOpeningController : Controller{
        public IActionResult Index()
        {
            return View();
        }
        private readonly IJobOpeningService _service;

        public JobOpeningController(IJobOpeningService service)
        {
            _service = service;
        }
    }
}