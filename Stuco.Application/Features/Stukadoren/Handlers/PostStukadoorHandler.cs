using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class PostStukadoorHandler : IPostHandler<CreateStukadoorDto, StukadoorDto>
{
    public async Task<StukadoorDto> ExecuteAsync(CreateStukadoorDto dto)
    {
        return new StukadoorDto() { Name = dto.Name };
    }
}