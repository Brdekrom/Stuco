using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos.Create;

namespace Stuco.Application.Features.Projecten.Handlers;

public class CreateProjectHandler : ICreateHandler<CreateProjectDto, ProjectDto>
{
    public async Task<ProjectDto> ExecuteAsync(CreateProjectDto dto)
    {
        return new ProjectDto() { Name = dto.Name };
    }
}