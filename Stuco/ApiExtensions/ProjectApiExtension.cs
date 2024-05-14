using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.ApiExtensions;

public static class ProjectApiExtension
{
    public static void MapProjectEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/project", async (IGetHandler<List<ProjectDto>> handler) =>
        {
            return await handler.ExecuteAsync();
        });

        endpoints.MapGet("/project/{id:int}", async (int id, IGetByIdHandler<ProjectDto> handler) =>
        {
            return handler.ExecuteAsync(id);
        });

        endpoints.MapPost("/project", async (ProjectDto project, IPostHandler<ProjectDto> handler) =>
        {
            return await handler.ExecuteAsync(project);
        });
    }
}