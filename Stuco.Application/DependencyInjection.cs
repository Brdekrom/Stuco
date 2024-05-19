using Microsoft.Extensions.DependencyInjection;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.Klanten.Handlers;
using Stuco.Application.Features.Projecten.Handlers;
using Stuco.Application.Features.Stukadoren.Handlers;

namespace Stuco.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGetHandler<List<StukadoorDto>>, GetStukadoorHandler>();
        services.AddScoped<IGetHandler<List<KlantDto>>, GetKlantHandler>();
        services.AddScoped<IGetHandler<List<ProjectDto>>, GetProjectHandler>();

        services.AddScoped<IGetByIdHandler<StukadoorDto>, GetStukadoorByIdHandler>();
        services.AddScoped<IGetByIdHandler<KlantDto>, GetKlantByIdHandler>();
        services.AddScoped<IGetByIdHandler<ProjectDto>, GetProjectByIdHandler>();

        services.AddScoped<IPostHandler<CreateStukadoorDto, StukadoorDto>, PostStukadoorHandler>();
        services.AddScoped<IPostHandler<CreateKlantDto, KlantDto>, PostKlantHandler>();
        services.AddScoped<IPostHandler<CreateProjectDto, ProjectDto>, PostProjectHandler>();

        return services;
    }
}