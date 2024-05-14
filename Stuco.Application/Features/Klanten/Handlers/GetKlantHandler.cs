using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Klanten.Handlers;

public class GetKlantHandler : IGetHandler<List<KlantDto>>
{
    public async Task<List<KlantDto>> ExecuteAsync()
    {
        return new List<KlantDto>() { new KlantDto() };
    }
}