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

        endpoints.MapPost(KlantEndpoint, async ([FromBody] KlantDto klant, [FromServices] ICreateHandler<KlantDto, Klant> handler) =>
        {
            var context = new ValidationContext(klant);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(klant, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(klant);
            return Results.Ok(result);
        });

        endpoints.MapPut(KlantEndpoint, async ([FromBody] Klant klant, [FromServices] IUpdateHandler<Klant> handler) =>
        {
            var context = new ValidationContext(klant);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(klant, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(klant);
            if (!result)
            {
                return Results.BadRequest();
            }

            return Results.Ok();
        });

        endpoints.MapDelete("/klant/{id:int}", async ([FromRoute] int id, [FromServices] IDeleteHandler<Klant> handler) =>
        {
            if (!await handler.ExecuteAsync(id))
            {
                return Results.BadRequest();
            }

            return Results.NoContent();
        });
    }
}