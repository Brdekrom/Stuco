using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Klant;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

internal class KlantRequestHandler : IRequestHandler<DtoBase, ViewKlantDto>
{
    private readonly IRepository<Klant> _repository;
    private readonly IMapper _mapper;

    public KlantRequestHandler(IMapper mapper, IRepository<Klant> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ViewKlantDto> Create(DtoBase dto)
    {
        var klant = _mapper.Map<CreateKlantDto, Klant>((CreateKlantDto)dto);
        await _repository.AddAsync(klant);
        return _mapper.Map<ViewKlantDto>(klant);
    }

    public async Task<bool> Delete(int id)
    {
        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<ViewKlantDto> Get(int id)
    {
        var klant = await _repository.GetByIdAsync(id);
        return _mapper.Map<ViewKlantDto>(klant);
    }

    public async Task<IEnumerable<ViewKlantDto>> GetAll()
    {
        var klanten = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ViewKlantDto>>(klanten);
    }

    public async Task<bool> Update(DtoBase dto)
    {
        var klant = _mapper.Map<UpdateKlantDto, Klant>((UpdateKlantDto)dto);
        await _repository.AddAsync(klant);

        return true;
    }
}