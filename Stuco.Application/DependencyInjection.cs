using Microsoft.Extensions.DependencyInjection;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos.Create;
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

        services.AddScoped<ICreateHandler<CreateStukadoorDto, Stukadoor>, CreateStukadoorHandler>();
        services.AddScoped<ICreateHandler<CreateKlantDto, Klant>, PostKlantHandler>();
        services.AddScoped<ICreateHandler<CreateProjectDto, Project>, CreateProjectHandler>();

        return services;
    }
}