using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;
using System.ComponentModel.DataAnnotations;

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

        endpoints.MapPost(StukadorEndpoint, async ([FromBody] StukadoorDto stukadoor, [FromServices] ICreateHandler<StukadoorDto, Stukadoor> handler) =>
        {
            var context = new ValidationContext(stukadoor);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(stukadoor, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(stukadoor);
            return Results.Ok(result);
        });

        endpoints.MapPut(StukadorEndpoint, async ([FromBody] Stukadoor stukadoor, [FromServices] IUpdateHandler<Stukadoor> handler) =>
        {
            var context = new ValidationContext(stukadoor);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(stukadoor, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(stukadoor);
            if (!result)
            {
                return Results.BadRequest();
            }

            return Results.Ok();
        });

        endpoints.MapDelete("/stukadoor/{id:int}", async ([FromRoute] int id, [FromServices] IDeleteHandler<Stukadoor> handler) =>
        {
            if (!await handler.ExecuteAsync(id))
            {
                return Results.BadRequest();
            }

            return Results.NoContent();
        });
    }
}