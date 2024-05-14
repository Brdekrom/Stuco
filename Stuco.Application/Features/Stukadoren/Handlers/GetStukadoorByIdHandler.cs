using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Get;

public class GetStukadoorById : IGetByIdHandler<StukadoorDto>
{
    public async Task<StukadoorDto> Execute(int id)
    {
        return new StukadoorDto();
    }
}