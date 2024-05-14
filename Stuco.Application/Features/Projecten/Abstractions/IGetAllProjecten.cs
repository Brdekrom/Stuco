using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Projecten.Abstractions;

public interface IGetAllProjecten
{
    Task<List<ProjectDto>> Execute();
}