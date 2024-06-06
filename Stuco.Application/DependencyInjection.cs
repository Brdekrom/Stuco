using Microsoft.Extensions.DependencyInjection;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Klant;
using Stuco.Application.Dtos.Project;
using Stuco.Application.Dtos.Stukadoor;
using Stuco.Application.Features.Klanten.Handlers;
using Stuco.Application.Features.Projects.Handlers;
using Stuco.Application.Features.Stukadoors.Handlers;

namespace Stuco.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<DtoBase, ViewKlantDto>, KlantRequestHandler>();
        services.AddScoped<IRequestHandler<DtoBase, ViewProjectDto>, ProjectRequestHandler>();
        services.AddScoped<IRequestHandler<DtoBase, ViewStukadoorDto>, StukadoorRequestHandler>();

        return services;
    }
}