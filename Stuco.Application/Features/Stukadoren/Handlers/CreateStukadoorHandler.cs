using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos.Create;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class CreateStukadoorHandler : ICreateHandler<CreateStukadoorDto, Stukadoor>
{
    public async Task<Stukadoor> ExecuteAsync(CreateStukadoorDto dto)
    {
        return new Stukadoor() { Name = dto.Name };
    }
}