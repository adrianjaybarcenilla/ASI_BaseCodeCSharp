using Microsoft.AspNetCore.Builder;

namespace Basecode.WebApp
{
    public partial class Startup
    {
        private void ConfigureRoutes(IApplicationBuilder app)
        {            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "token",
                    pattern: "api/{token}");
            });
        }
    }
}
