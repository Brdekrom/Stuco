using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projecten.Handlers;

public class DeleteProjectHandler : IDeleteHandler<Project>
{
    public Task<bool> ExecuteAsync(int id)
    {
        return Task.FromResult(true);
    }
}