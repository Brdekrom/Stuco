using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Klant;
using Stuco.Application.Features.Klanten.Handlers;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<DtoBase, ViewKlantDto>, KlantRequestHandler>();

        return services;
    }
}