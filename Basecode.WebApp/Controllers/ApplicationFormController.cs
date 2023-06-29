using Basecode.Main.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Basecode.WebApp.Controllers
{
    public class ApplicationFormController : Controller
    {
        private readonly ILogger<ApplicationFormController> _logger;

        public ApplicationFormController(ILogger<ApplicationFormController> logger)
        {
            _logger = logger;
        }

        public IActionResult ApplicationPage()
        {
            return View();
        }
    }
}
