using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class GetStukadoorHandler : IGetHandler<List<StukadoorDto>>
{
    public async Task<List<StukadoorDto>> ExecuteAsync()
    {
        return new List<StukadoorDto>();
    }
}