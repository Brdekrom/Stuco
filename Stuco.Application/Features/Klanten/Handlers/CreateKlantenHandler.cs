using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Klanten.Handlers;

public class PostKlantHandler : ICreateHandler<KlantDto, Klant>
{
    private readonly IRepository<Klant> _repository;
    private readonly IMapper _mapper;

    public PostKlantHandler(IRepository<Klant> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper!;
    }

    public async Task<Klant> ExecuteAsync(KlantDto dto)
    {
        var klant = _mapper.Map<KlantDto, Klant>(dto);
        await _repository.AddAsync(klant);
        return klant;
    }
}