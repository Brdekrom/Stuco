using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projecten.Handlers;

public class GetProjectByIdHandler : IGetByIdHandler<Project>
{
    public async Task<Project> ExecuteAsync(int id)
    {
        return new Project() { Id = id };
    }
}