using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.Stukadoren.Abstractions;

namespace Stuco.Application.Features.Stukadoren.Get;

internal class GetStukadoor : IGetStukadoor
{
    public Task<List<StukadoorDto>> Execute(int id)
    {
        throw new NotImplementedException();
    }
}