using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Get;

internal class GetAllStukadoren : IRequestHandler<List<StukadoorDto>>
{
    public Task<List<StukadoorDto>> Execute()
    {
        throw new NotImplementedException();
    }
}