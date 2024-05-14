using Stuco.Application.Features.Dtos;

namespace Stuco.Application.Features.GetKlanten.Abstraction;

public interface IGetAllKlanten
{
    Task<List<KlantDto>> Execute();
}