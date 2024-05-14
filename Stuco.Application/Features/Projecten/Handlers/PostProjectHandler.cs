using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Projecten.Handlers;

public class PostProjectHandler : IPostHandler<ProjectDto>
{
    public async Task<ProjectDto> ExecuteAsync(ProjectDto dto)
    {
        return dto;
    }
}