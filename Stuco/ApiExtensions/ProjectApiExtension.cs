using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Api.ApiExtensions;

public static class ProjectApiExtension
{
    private const string ProjectEndpoint = "/project";

    public static void MapProjectEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(ProjectEndpoint, async ([FromServices] IGetHandler<List<ProjectDto>> handler) =>
        {
            return await handler.ExecuteAsync();
        });

        endpoints.MapGet("/project/{id:int}", async ([FromRoute] int id, [FromServices] IGetByIdHandler<ProjectDto> handler) =>
        {
            return handler.ExecuteAsync(id);
        });

        endpoints.MapPost(ProjectEndpoint, async ([FromBody] ProjectDto project, [FromServices] ICreateHandler<ProjectDto, Project> handler) =>
        {
            if (!ValidateProject(project, out var validationResults))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(project);
            return Results.Ok(result);
        });

        endpoints.MapPut(ProjectEndpoint, async ([FromBody] ProjectDto project, [FromServices] IUpdateHandler<ProjectDto> handler) =>
        {
            if (!ValidateProject(project, out var validationResults))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(project);
            return Results.Ok(result);
        });

        endpoints.MapDelete("/project/{id:int}", async ([FromRoute] int id, [FromServices] IDeleteHandler<Project> handler) =>
        {
            if (!await handler.ExecuteAsync(id))
            {
                return Results.BadRequest();
            }

            return Results.NoContent();
        });
    }

    private static bool ValidateProject(ProjectDto project, out IEnumerable<ValidationResult> validationResults)
    {
        var context = new ValidationContext(project);
        validationResults = new List<ValidationResult>();
        return Validator.TryValidateObject(project, context, (ICollection<ValidationResult>)validationResults, true);
    }
}