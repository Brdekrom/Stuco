using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projecten.Handlers;

public class CreateProjectHandler : ICreateHandler<ProjectDto, Project>
{
    public async Task<Project> ExecuteAsync(ProjectDto dto)
    {
        return new Project() { Name = dto.Name };
    }
}