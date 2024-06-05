using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Dtos.Stukadoor;
using Stuco.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Api.ApiExtensions;

internal static class StukadoorApiExtension
{
    private const string StukadorEndpoint = "/stukadoor";

    internal static async void MapStukadoorEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(StukadorEndpoint, async ([FromServices] IRequestHandler<DtoBase, Stukadoor> handler) =>
        {
            return await handler.GetAll();
        });

        endpoints.MapGet("/stukadoor/{id:int}", async ([FromRoute] int id, [FromServices] IRequestHandler<DtoBase, Stukadoor> handler) =>
        {
            return await handler.Get(id);
        });

        endpoints.MapPost(StukadorEndpoint, async ([FromBody] CreateStukadoorDto stukadoor, [FromServices] IRequestHandler<DtoBase, Stukadoor> handler) =>
        {
            var context = new ValidationContext(stukadoor);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(stukadoor, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.Create(stukadoor);
            return Results.Ok(result);
        });

        endpoints.MapPut(StukadorEndpoint, async ([FromBody] UpdateStukadoorDto stukadoor, [FromServices] IRequestHandler<DtoBase, Stukadoor> handler) =>
        {
            var context = new ValidationContext(stukadoor);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(stukadoor, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.Update(stukadoor);
            if (!result)
            {
                return Results.BadRequest();
            }

            return Results.Ok();
        });

        endpoints.MapDelete("/stukadoor/{id:int}", async ([FromRoute] int id, [FromServices] IRequestHandler<DtoBase, Stukadoor> handler) =>
        {
            if (!await handler.Delete(id))
            {
                return Results.BadRequest();
            }

            return Results.NoContent();
        });
    }
}