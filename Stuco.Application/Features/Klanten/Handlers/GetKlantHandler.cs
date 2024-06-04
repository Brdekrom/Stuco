using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class GetKlantHandler : IGetHandler<List<Klant>>
{
    private IRepository<Klant> _repository;

    public GetKlantHandler(IRepository<Klant> repository)
    {
        _repository = repository;
    }

    public async Task<List<Klant>> ExecuteAsync()
    {
        return await _repository.GetAllAsync();
    }
}