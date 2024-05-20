using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class UpdateStukadoorHandler : IUpdateHandler<Stukadoor>
{
    public Task<bool> ExecuteAsync(Stukadoor dto)
    {
        return Task.FromResult(true);
    }
}