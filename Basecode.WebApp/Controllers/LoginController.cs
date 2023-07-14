using Basecode.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login([Bind("Email,Password")] LoginModel loginModel)
        {
            return RedirectToAction("Index", "Dashboard", loginModel);
        }
    }
}
