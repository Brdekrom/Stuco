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
            var context = new ValidationContext(project);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(project, context, validationResults, true))
            {
                return Results.BadRequest(validationResults);
            }

            var result = await handler.ExecuteAsync(project);
            return Results.Ok(result);
        });

        endpoints.MapPut(ProjectEndpoint, async ([FromBody] Project project, [FromServices] IUpdateHandler<Project> handler) =>
        {
            var context = new ValidationContext(project);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(project, context, validationResults, true))
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
}