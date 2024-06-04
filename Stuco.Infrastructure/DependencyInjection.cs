using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;
using Stuco.Infrastructure.Persistence;
using Stuco.Infrastructure.Repositories;

namespace Stuco.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration, bool isDev)
    {
        if (!isDev)
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
                options.UseMySQL(configuration.GetConnectionString("DefaultConnection"));
            });
        }

        services.AddScoped<IRepository<Klant>, KlantRepository>();
        services.AddScoped<IRepository<Project>, ProjectRepository>();
        services.AddScoped<IRepository<Stukadoor>, StukadoorRepository>();
    }
}