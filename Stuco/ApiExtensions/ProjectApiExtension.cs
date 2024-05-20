using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.Dtos.Create;

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

        endpoints.MapPost(ProjectEndpoint, async ([FromBody] CreateProjectDto project, [FromServices] ICreateHandler<CreateProjectDto, ProjectDto> handler) =>
        {
            return await handler.ExecuteAsync(project);
        });
    }
}