using Stuco.Application.Features.Dtos;
using Stuco.Application.Features.GetKlanten.Abstraction;

namespace Stuco.Application.Features.Klanten.Get;

public class GetKlant : IGetKlant
{
    public Task<List<KlantDto>> Execute(int id)
    {
        throw new NotImplementedException();
    }
}