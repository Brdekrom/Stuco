using Stuco.Application.Abstractions

using Stuco.Application.Features.Dtos.Create;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class PostKlantHandler : ICreateHandler<CreateKlantDto, Klant>
{
    public async Task<KlantDto> ExecuteAsync(CreateKlantDto dto)
    {
        return new KlantDto() { Name = dto.Name };
    }
}