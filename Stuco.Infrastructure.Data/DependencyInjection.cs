using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stuco.Application.Abstractions;
using Stuco.Infrastructure.Persistence;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration, bool isDev)
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

        services.AddScoped<IRepository, StucoRepository>();
        
        return services;
    }
}