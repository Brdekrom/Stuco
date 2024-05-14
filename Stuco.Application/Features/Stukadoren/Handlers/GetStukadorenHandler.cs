using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.Stukadoren.Abstractions;

namespace Stuco.Application.Features.Stukadoren.Get;

internal class GetAllStukadoren : IRequestHandler<List<StukadoorDto>>
{
    public Task<List<StukadoorDto>> Execute()
    {
        throw new NotImplementedException();
    }
}