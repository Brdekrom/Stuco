using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Project;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Api.ApiExtensions;

public static class ProjectApiExtension
{
    private const string ProjectEndpoint = "/project";

    public static void MapProjectEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(ProjectEndpoint, async ([FromServices] IRequestHandler<DtoBase, ViewProjectDto> handler) =>
        {
            return await handler.GetAll();
        });

        endpoints.MapGet("/project/{id:int}", async ([FromRoute] int id, [FromServices] IRequestHandler<DtoBase, ViewProjectDto> handler) =>
        {
            return handler.Get(id);
        });

        endpoints.MapPost(ProjectEndpoint, async ([FromBody] CreateProjectDto project, [FromServices] IRequestHandler<DtoBase, ViewProjectDto> handler) =>
        {
            var context = new ValidationContext(project);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(project, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.Create(project);
            return Results.Ok(result);
        });

        endpoints.MapPut(ProjectEndpoint, async ([FromBody] UpdateProjectDto project, [FromServices] IRequestHandler<DtoBase, ViewProjectDto> handler) =>
        {
            var context = new ValidationContext(project);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(project, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.Update(project);
            return Results.Ok(result);
        });

        endpoints.MapDelete("/project/{id:int}", async ([FromRoute] int id, [FromServices] IRequestHandler<DtoBase, ViewProjectDto> handler) =>
        {
            if (!await handler.Delete(id))
            {
                return Results.BadRequest();
            }

            return Results.NoContent();
        });
    }
}