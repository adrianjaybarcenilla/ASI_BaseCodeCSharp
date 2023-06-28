using Microsoft.Extensions.DependencyInjection;

namespace Basecode.WebApp
{
    public partial class Startup
    {
        private void ConfigureMVC(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}
