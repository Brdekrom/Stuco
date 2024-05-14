using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.Stukadoren.Abstractions;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class PostStukadoor : IRequestHandler<StukadoorDto>
{
    public Task<StukadoorDto> Execute()
    {
        throw new NotImplementedException();
    }
}