using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class GetKlantByIdHandler : IGetByIdHandler<Klant>
{
    public async Task<Klant> ExecuteAsync(int id)
    {
        return new() { Id = id };
    }
}