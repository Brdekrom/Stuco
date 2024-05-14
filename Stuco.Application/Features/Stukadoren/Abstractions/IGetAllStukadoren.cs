using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Abstractions;

public interface IGetAllStukadoren
{
    Task<List<StukadoorDto>> Execute();
}