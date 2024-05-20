using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class CreateStukadoorHandler : ICreateHandler<StukadoorDto, Stukadoor>
{
    public async Task<Stukadoor> ExecuteAsync(StukadoorDto dto)
    {
        return new Stukadoor() { Name = dto.Name };
    }
}