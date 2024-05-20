using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class GetStukadoorByIdHandler : IGetByIdHandler<Stukadoor>
{
    public async Task<Stukadoor> ExecuteAsync(int id)
    {
        return new Stukadoor();
    }
}