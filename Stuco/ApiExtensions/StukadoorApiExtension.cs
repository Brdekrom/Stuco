using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Api.ApiExtensions;

internal static class StukadoorApiExtension
{
    private const string BaseUrl = "/stukadoor";

    internal static async void MapStukadoorEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(BaseUrl, async (IGetHandler<StukadoorDto> handler) =>
        {
            return await handler.Execute();
        });

        endpoints.MapGet("{BaseUrl}/{id:int}", async (int id, IGetByIdHandler<List<StukadoorDto>> handler) =>
        {
            return await handler.Execute(id);
        });

        endpoints.MapPost(BaseUrl, async (Stukadoor stukadoor, IPostHandler<Stukadoor> handler) =>
        {
            return await handler.Execute(stukadoor);
        });
    }
}