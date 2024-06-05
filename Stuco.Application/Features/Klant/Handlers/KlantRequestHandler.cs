using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Dtos.Klant;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

internal class KlantRequestHandler : IRequestHandler<DtoBase, Klant>
{
    private readonly IRepository<Klant> _repository;
    private readonly IMapper _mapper;

    public KlantRequestHandler(IMapper mapper, IRepository<Klant> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<Klant> Create(DtoBase dto)
    {
        var klant = _mapper.Map<CreateKlantDto, Klant>((CreateKlantDto)dto);
        await _repository.AddAsync(klant);
        return klant;
    }

    public async Task<bool> Delete(int id)
    {
        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<Klant> Get(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Klant>> GetAll()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<bool> Update(DtoBase dto)
    {
        var klant = _mapper.Map<UpdateKlantDto, Klant>((UpdateKlantDto)dto);
        await _repository.AddAsync(klant);
        return true;
    }
}