using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Get;

internal class GetAllStukadoren : IGetHandler<List<StukadoorDto>>
{
    public Task<List<StukadoorDto>> Execute()
    {
        throw new NotImplementedException();
    }
}