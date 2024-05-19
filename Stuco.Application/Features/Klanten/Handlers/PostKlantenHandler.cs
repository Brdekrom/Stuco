using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Klanten.Handlers;

public class PostKlantHandler : IPostHandler<CreateKlantDto, KlantDto>
{
    public async Task<KlantDto> ExecuteAsync(CreateKlantDto dto)
    {
        return new KlantDto() { Name = dto.Name };
    }
}