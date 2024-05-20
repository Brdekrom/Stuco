using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class UpdateKlantHandler : IUpdateHandler<Klant>
{
    public Task<bool> ExecuteAsync(Klant dto)
    {
        return Task.FromResult(true);
    }
}