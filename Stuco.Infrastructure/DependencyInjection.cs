using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stuco.Infrastructure.Persistence;

namespace Stuco.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration, bool isDev)
    {
        if (isDev)
        {
            services.AddDbContext<StucoDBContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDb");
            });
        }
        else
        {
            services.AddDbContext<StucoDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }

        //services.AddScoped<IStukadoorRepository, StukadoorRepository>();
        //services.AddScoped<IKlantRepository, KlantRepository>();
        //services.AddScoped<IProjectRepository, ProjectRepository>();
    }
}