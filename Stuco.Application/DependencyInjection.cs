using Microsoft.Extensions.DependencyInjection;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.GetKlanten.Abstraction;
using Stuco.Application.Features.Klanten.Get;
using Stuco.Application.Features.Projecten.Abstractions;
using Stuco.Application.Features.Projecten.Get;
using Stuco.Application.Features.Stukadoren.Get;
using Stuco.Application.Features.Stukadoren.Handlers;

namespace Stuco.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGetKlant, GetKlant>();
        services.AddScoped<IGetAllKlanten, GetAllKlanten>();
        services.AddScoped<IGetProject, GetProject>();
        services.AddScoped<IGetAllProjecten, GetAllProjecten>();

        services.AddScoped<IGetHandler<List<StukadoorDto>>, GetStukadoor>();

        services.AddScoped<IGetByIdHandler<StukadoorDto>, GetStukadoorById>();

        services.AddScoped<IPostHandler<StukadoorDto>, PostStukadoor>();

        return services;
    }
}