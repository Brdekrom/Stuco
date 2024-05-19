using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Projecten.Handlers;

public class PostProjectHandler : IPostHandler<CreateProjectDto, ProjectDto>
{
    public async Task<ProjectDto> ExecuteAsync(CreateProjectDto dto)
    {
        return new ProjectDto() { Name = dto.Name };
    }
}