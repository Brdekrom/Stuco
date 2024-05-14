using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Get;

public class GetStukadoor : IGetHandler<List<StukadoorDto>>
{
    public async Task<List<StukadoorDto>> Execute()
    {
        return new List<StukadoorDto>();
    }
}