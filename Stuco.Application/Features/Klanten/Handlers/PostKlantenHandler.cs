using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Klanten.Handlers;

public class PostKlantHandler : IPostHandler<KlantDto>
{
    public async Task<KlantDto> ExecuteAsync(KlantDto dto)
    {
        return dto;
    }
}