using Stuco.Application.Abstractions;
using Stuco.Application.Services;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ISession, StucoSession>();
        return services;
    }
}