using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.ApiExtensions;

internal static class StukadoorApiExtension
{
    private const string StukadorEndpoint = "/stukadoor";

    internal static async void MapStukadoorEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(StukadorEndpoint, async ([FromServices] IGetHandler<List<StukadoorDto>> handler) =>
        {
            return await handler.ExecuteAsync();
        });

        endpoints.MapGet("/stukadoor/{id:int}", async ([FromRoute] int id, [FromServices] IGetByIdHandler<StukadoorDto> handler) =>
        {
            return await handler.ExecuteAsync(id);
        });

        endpoints.MapPost(StukadorEndpoint, async ([FromBody] CreateStukadoorDto stukadoor, [FromServices] IPostHandler<CreateStukadoorDto, StukadoorDto> handler) =>
        {
            return await handler.ExecuteAsync(stukadoor);
        });
    }
}