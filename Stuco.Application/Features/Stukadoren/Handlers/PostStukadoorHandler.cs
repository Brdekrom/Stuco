using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class PostStukadoorHandler : IPostHandler<StukadoorDto>
{
    public async Task<StukadoorDto> ExecuteAsync(StukadoorDto dto)
    {
        return new StukadoorDto();
    }
}