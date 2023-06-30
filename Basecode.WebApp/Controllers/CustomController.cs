using Microsoft.AspNetCore.Mvc;

namespace MVCAppTest.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult CustomHomePage()
        {
            return View();
        }
    }
}
