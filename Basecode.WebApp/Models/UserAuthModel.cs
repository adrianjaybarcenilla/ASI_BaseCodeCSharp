using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Basecode.Main.Models
{
    public class UserAuthModel:PageModel
    {
        public bool IsUserAuthenticated { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsHRManager { get; set; }

        public void OnGet()
        {
            IsUserAuthenticated = User.Identity.IsAuthenticated;
            IsAdmin = User.IsInRole("Admin");
            IsHRManager = User.IsInRole("Manager");
        }
    }
}