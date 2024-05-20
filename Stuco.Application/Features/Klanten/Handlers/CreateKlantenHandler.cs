using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class PostKlantHandler : ICreateHandler<KlantDto, Klant>
{
    public async Task<Klant> ExecuteAsync(KlantDto dto)
    {
        return new Klant() { Name = dto.Name };
    }
}