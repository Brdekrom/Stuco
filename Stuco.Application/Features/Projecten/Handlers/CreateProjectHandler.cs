using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos.Create;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projecten.Handlers;

public class CreateProjectHandler : ICreateHandler<CreateProjectDto, Project>
{
    public async Task<Project> ExecuteAsync(CreateProjectDto dto)
    {
        return new Project() { Name = dto.Name };
    }
}