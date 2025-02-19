using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stuco.Infrastructure.Persistence;

namespace Microsoft.Extensions.DependencyInjection;

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
    }
}