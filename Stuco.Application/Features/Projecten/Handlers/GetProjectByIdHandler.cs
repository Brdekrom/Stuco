using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Projecten.Handlers;

public class GetProjectByIdHandler : IGetByIdHandler<ProjectDto>
{
    public async Task<ProjectDto> ExecuteAsync(int id)
    {
        return new ProjectDto() { Id = id };
    }
}