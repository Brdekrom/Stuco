using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.Projecten.Abstractions;

namespace Stuco.Application.Features.Projecten.Get;

public class GetProject : IGetProject
{
    public Task<List<ProjectDto>> Execute(int id)
    {
        throw new NotImplementedException();
    }
}