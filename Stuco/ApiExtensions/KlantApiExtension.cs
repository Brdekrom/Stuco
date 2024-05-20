using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos.Create;
using System.ComponentModel.DataAnnotations;

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

        endpoints.MapPost(KlantEndpoint, async ([FromBody] CreateKlantDto klant, [FromServices] ICreateHandler<CreateKlantDto, KlantDto> handler) =>
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(klant);

            // Data annotations validation
            if (!Validator.TryValidateObject(klant, validationContext, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(klant);
            return Results.Ok(result);
        });
    }
}