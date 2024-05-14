using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Abstractions;

public interface IGetStukadoor
{
    Task<List<StukadoorDto>> Execute(int id);
}