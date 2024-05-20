using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projecten.Handlers;

public class UpdateProjectHandler : IUpdateHandler<Project>
{
    public Task<bool> ExecuteAsync(Project dto)
    {
        return Task.FromResult(true);
    }
}