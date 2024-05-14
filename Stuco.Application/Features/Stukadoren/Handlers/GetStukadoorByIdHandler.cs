using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class GetStukadoorByIdHandler : IGetByIdHandler<StukadoorDto>
{
    public async Task<StukadoorDto> ExecuteAsync(int id)
    {
        return new StukadoorDto();
    }
}