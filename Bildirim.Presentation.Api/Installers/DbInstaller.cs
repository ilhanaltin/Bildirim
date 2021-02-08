using Bildirim.App.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bildirim.Presentation.Api.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BildirimContext>(options => {
                options.UseSqlServer(
                     configuration.GetConnectionString("ProdConnection"));
                options.UseLazyLoadingProxies(true);
                options.EnableDetailedErrors(true);
            });
        }
    }
}
