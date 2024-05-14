using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.ApiExtensions;

public static class KlantApiExtension
{
    private const string KlantEndpoint = "/klant";

    public static async void MapKlantEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(KlantEndpoint, async (IGetHandler<List<KlantDto>> handler) =>
        {
            return await handler.ExecuteAsync();
        });

        endpoints.MapGet("{KlantEndpoint}/{id:int}", async (int id, IGetByIdHandler<List<KlantDto>> handler) =>
        {
            return await handler.ExecuteAsync(id);
        });

        endpoints.MapPost(KlantEndpoint, async (KlantDto klant, IPostHandler<KlantDto> handler) =>
        {
            return await handler.ExecuteAsync(klant);
        });
    }
}