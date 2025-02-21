using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stuco.Application.Abstractions;
using Stuco.Infrastructure.Persistence;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("StucoDB");

        if (connectionString == null)
        {
            throw new ApplicationException("Missing connection string in configuration");
        }
        
        services.AddDbContext<StucoDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IRepository, StucoRepository>();
        
        using var scope = services.BuildServiceProvider().CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<StucoDbContext>();
        dbContext.Database.Migrate();

        return services;
    }
}