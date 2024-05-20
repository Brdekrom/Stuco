using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class DeleteKlantHandler : IDeleteHandler<Klant>
{
    public Task<bool> ExecuteAsync(int id)
    {
        return Task.FromResult(true);
    }
}