using Stuco.Application.Abstractions;

using Stuco.Application.Features.Dtos.Create;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class PostKlantHandler : ICreateHandler<CreateKlantDto, Klant>
{
    public async Task<Klant> ExecuteAsync(CreateKlantDto dto)
    {
        return new Klant() { Name = dto.Name };
    }
}