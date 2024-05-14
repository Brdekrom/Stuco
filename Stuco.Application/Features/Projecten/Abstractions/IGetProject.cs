using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Projecten.Abstractions;

public interface IGetProject
{
    Task<List<ProjectDto>> Execute(int id);
}