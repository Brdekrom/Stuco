using Microsoft.Extensions.DependencyInjection;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.Klanten.Handlers;
using Stuco.Application.Features.Projecten.Handlers;
using Stuco.Application.Features.Stukadoren.Handlers;
using Stuco.Domain.Entities;

namespace Stuco.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGetHandler<List<Stukadoor>>, GetStukadoorHandler>();
        services.AddScoped<IGetHandler<List<Klant>>, GetKlantHandler>();
        services.AddScoped<IGetHandler<List<Project>>, GetProjectHandler>();

        services.AddScoped<IGetByIdHandler<Stukadoor>, GetStukadoorByIdHandler>();
        services.AddScoped<IGetByIdHandler<Klant>, GetKlantByIdHandler>();
        services.AddScoped<IGetByIdHandler<Project>, GetProjectByIdHandler>();

        services.AddScoped<ICreateHandler<StukadoorDto, Stukadoor>, CreateStukadoorHandler>();
        services.AddScoped<ICreateHandler<KlantDto, Klant>, PostKlantHandler>();
        services.AddScoped<ICreateHandler<ProjectDto, Project>, CreateProjectHandler>();

        services.AddScoped<IUpdateHandler<Stukadoor>, UpdateStukadoorHandler>();
        services.AddScoped<IUpdateHandler<Klant>, UpdateKlantHandler>();
        services.AddScoped<IUpdateHandler<Project>, UpdateProjectHandler>();

        return services;
    }
}