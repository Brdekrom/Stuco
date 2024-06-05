using Microsoft.Extensions.DependencyInjection;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Features.Klanten.Handlers;
using Stuco.Application.Features.Projects.Handlers;
using Stuco.Application.Features.Stukadoors.Handlers;
using Stuco.Domain.Entities;

namespace Stuco.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<DtoBase, Klant>, KlantRequestHandler>();
        services.AddScoped<IRequestHandler<DtoBase, Project>, ProjectRequestHandler>();
        services.AddScoped<IRequestHandler<DtoBase, Stukadoor>, StukadoorRequestHandler>();

        return services;
    }
}