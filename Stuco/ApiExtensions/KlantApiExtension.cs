using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;
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

        endpoints.MapPost(KlantEndpoint, async ([FromBody] KlantDto klant, [FromServices] ICreateHandler<KlantDto, KlantDto> handler) =>
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(klant);

            if (!Validator.TryValidateObject(klant, validationContext, validationResults, false))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(klant);
            return Results.Ok(result);
        });

        endpoints.MapPut("/klant/{id:int}", async ([FromRoute] int id, [FromBody] KlantDto klant, [FromServices] IUpdateHandler<Klant> handler) =>
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(klant);

            if (!Validator.TryValidateObject(klant, validationContext, validationResults, false))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(id, klant);
            return Results.Ok(result);
        });
    }
}