using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos.Create;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class CreateStukadoorHandler : ICreateHandler<CreateStukadoorDto, StukadoorDto>
{
    public async Task<StukadoorDto> ExecuteAsync(CreateStukadoorDto dto)
    {
        return new StukadoorDto() { Name = dto.Name };
    }
}