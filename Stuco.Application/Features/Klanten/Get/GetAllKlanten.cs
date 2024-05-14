using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.GetKlanten.Abstraction;

namespace Stuco.Application.Features.Klanten.Get;

public class GetAllKlanten : IGetAllKlanten
{
    public Task<List<KlantDto>> Execute()
    {
        throw new NotImplementedException();
    }
}