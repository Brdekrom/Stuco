using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.Klanten.Handlers;

public class GetKlantByIdHandler : IGetByIdHandler<KlantDto>
{
    public async Task<KlantDto> ExecuteAsync(int id)
    {
        return new() { Id = id };
    }
}