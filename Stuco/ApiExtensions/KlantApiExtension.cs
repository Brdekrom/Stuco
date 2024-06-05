using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Dtos.Klant;
using Stuco.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Api.ApiExtensions;

public static class KlantApiExtension
{
    private const string KlantEndpoint = "/klant";

    public static async void MapKlantEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(KlantEndpoint, async ([FromServices] IRequestHandler<DtoBase, Klant> handler) =>
        {
            return await handler.GetAll();
        });

        endpoints.MapGet("/klant/{id:int}", async ([FromRoute] int id, [FromServices] IRequestHandler<DtoBase, Klant> handler) =>
        {
            return await handler.Get(id);
        });

        endpoints.MapPost(KlantEndpoint, async ([FromBody] CreateKlantDto klant, [FromServices] IRequestHandler<DtoBase, Klant> handler) =>
        {
            var context = new ValidationContext(klant);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(klant, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.Create(klant);
            return Results.Ok(result);
        });

        endpoints.MapPut(KlantEndpoint, async ([FromBody] UpdateKlantDto klant, [FromServices] IRequestHandler<DtoBase, Klant> handler) =>
        {
            var context = new ValidationContext(klant);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(klant, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.Update(klant);
            if (!result)
            {
                return Results.BadRequest();
            }

            return Results.Ok();
        });

        endpoints.MapDelete("/klant/{id:int}", async ([FromRoute] int id, [FromServices] IRequestHandler<DtoBase, Klant> handler) =>
        {
            if (!await handler.Delete(id))
            {
                return Results.BadRequest();
            }

            return Results.NoContent();
        });
    }
}