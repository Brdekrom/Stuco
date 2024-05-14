using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.GetKlanten.Abstraction;

public interface IGetKlant
{
    Task<List<KlantDto>> Execute(int id);
}