using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class DeleteKlantHandler : IDeleteHandler<Klant>
{
    private IRepository<Klant> _repository;

    public Task<bool> ExecuteAsync(int id)
    {
        _repository.DeleteAsync(id);
        return Task.FromResult(true);
    }
}