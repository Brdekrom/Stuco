using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projecten.Handlers;

public class GetProjectHandler : IGetHandler<List<Project>>
{
    public async Task<List<Project>> ExecuteAsync()
    {
        return new List<Project>();
    }
}