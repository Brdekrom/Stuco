using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class GetKlantByIdHandler : IGetByIdHandler<Klant>
{
    private readonly IRepository<Klant> _repository;

    public GetKlantByIdHandler(IRepository<Klant> repository)
    {
        _repository = repository;
    }

    public async Task<Klant> ExecuteAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
}