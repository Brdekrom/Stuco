using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class PostStukadoor : IPostHandler<StukadoorDto>
{
    public Task<StukadoorDto> Execute()
    {
        throw new NotImplementedException();
    }
}