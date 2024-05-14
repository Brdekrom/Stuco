using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Get;

internal class GetStukadoor : IRequestHandler<StukadoorDto>
{
    public Task<StukadoorDto> Execute()
    {
        throw new NotImplementedException();
    }
}