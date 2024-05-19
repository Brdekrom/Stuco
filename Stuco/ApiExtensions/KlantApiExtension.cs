using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.ApiExtensions;

public static class KlantApiExtension
{
    private const string KlantEndpoint = "/klant";

    public static async void MapKlantEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(KlantEndpoint, async ([FromServices] IGetHandler<List<KlantDto>> handler) =>
        {
            return await handler.ExecuteAsync();
        });

        endpoints.MapGet("/klant/{id:int}", async ([FromRoute] int id, [FromServices] IGetByIdHandler<KlantDto> handler) =>
        {
            return await handler.ExecuteAsync(id);
        });

        endpoints.MapPost(KlantEndpoint, async ([FromBody] CreateKlantDto klant, [FromServices] IPostHandler<CreateKlantDto, KlantDto> handler) =>
        {
            return await handler.ExecuteAsync(klant);
        });
    }
}