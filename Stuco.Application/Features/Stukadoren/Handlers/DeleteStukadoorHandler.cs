using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class DeleteStukadoorHandler : IDeleteHandler<Stukadoor>
{
    public Task<bool> ExecuteAsync(int id)
    {
        return Task.FromResult(true);
    }
}