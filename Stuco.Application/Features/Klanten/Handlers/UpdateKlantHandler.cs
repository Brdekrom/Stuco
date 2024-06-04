using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class UpdateKlantHandler : IUpdateHandler<Klant>
{
    private readonly IRepository<Klant> _repository;

    public UpdateKlantHandler(IRepository<Klant> repository)
    {
        _repository = repository;
    }

    public Task<bool> ExecuteAsync(Klant klant)
    {
        _repository.UpdateAsync(klant);
        return Task.FromResult(true);
    }
}