using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class PostStukadoor : IPostHandler<StukadoorDto>
{
    public async Task<StukadoorDto> Execute(StukadoorDto dto)
    {
        return new StukadoorDto();
    }
}