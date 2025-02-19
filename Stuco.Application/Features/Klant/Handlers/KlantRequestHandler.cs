using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Klant;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

internal class KlantRequestHandler(IMapper mapper, IRepository<Client> repository)
    : IRequestHandler<DtoBase, ViewKlantDto>
{
    public async Task<ViewKlantDto> Create(DtoBase dto)
    {
        var klant = mapper.Map<CreateKlantDto, Client>((CreateKlantDto)dto);
        await repository.AddAsync(klant);
        return mapper.Map<ViewKlantDto>(klant);
    }

    public async Task<bool> Delete(int id)
    {
        await repository.DeleteAsync(id);
        return true;
    }

    public async Task<ViewKlantDto> Get(int id)
    {
        var klant = await repository.GetByIdAsync(id);
        return mapper.Map<ViewKlantDto>(klant);
    }

    public async Task<IEnumerable<ViewKlantDto>> GetAll()
    {
        var klanten = await repository.GetAllAsync();
        return mapper.Map<IEnumerable<ViewKlantDto>>(klanten);
    }

    public async Task<bool> Update(DtoBase dto)
    {
        var klant = mapper.Map<UpdateKlantDto, Client>((UpdateKlantDto)dto);
        await repository.AddAsync(klant);

        return true;
    }
}