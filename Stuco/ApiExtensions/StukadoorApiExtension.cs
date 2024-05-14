using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.ApiExtensions;

internal static class StukadoorApiExtension
{
    private const string StukadorEndpoint = "/stukadoor";

    internal static async void MapStukadoorEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(StukadorEndpoint, async (IGetHandler<StukadoorDto> handler) =>
        {
            return await handler.ExecuteAsync();
        });

        endpoints.MapGet("{BaseUrl}/{id:int}", async (int id, IGetByIdHandler<List<StukadoorDto>> handler) =>
        {
            return await handler.ExecuteAsync(id);
        });

        endpoints.MapPost(StukadorEndpoint, async (StukadoorDto stukadoor, IPostHandler<StukadoorDto> handler) =>
        {
            return await handler.ExecuteAsync(stukadoor);
        });
    }
}