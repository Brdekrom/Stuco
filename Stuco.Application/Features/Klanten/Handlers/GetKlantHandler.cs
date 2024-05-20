using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class GetKlantHandler : IGetHandler<List<Klant>>
{
    public async Task<List<Klant>> ExecuteAsync()
    {
        return new List<Klant>() { new Klant() };
    }
}