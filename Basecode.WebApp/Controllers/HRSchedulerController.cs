using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class HRSchedulerController : Controller
    {
        private readonly ILogger<HRSchedulerController> _logger;

        public HRSchedulerController(ILogger<HRSchedulerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
