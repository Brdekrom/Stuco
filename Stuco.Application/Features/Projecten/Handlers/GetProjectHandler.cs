using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Projecten.Handlers;

public class GetProjectHandler : IGetHandler<List<ProjectDto>>
{
    public async Task<List<ProjectDto>> ExecuteAsync()
    {
        return new List<ProjectDto>();
    }
}