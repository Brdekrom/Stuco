using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;
using Stuco.Infrastructure.Persistence;

namespace Stuco.Infrastructure.Repositories;

public class KlantRepository : IRepository<Klant>
{
    private readonly StucoDBContext _context;

    public KlantRepository(StucoDBContext context)
    {
        _context = context;
    }

    public Task<Klant> AddAsync(Klant klant)
    {
        _context.Klanten.Add(klant);
        _context.SaveChanges();
        return Task.FromResult(klant);
    }

    public Task DeleteAsync(int id)
    {
        var klant = _context.Klanten.FirstOrDefault(k => k.Id == id) ?? throw new Exception("Klant not found");
        _context.Klanten.Remove(klant);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

    public Task<List<Klant>> GetAllAsync()
    {
        return Task.FromResult(_context.Klanten.ToList());
    }

    public Task<Klant> GetByIdAsync(int id)
        => Task.FromResult(_context.Klanten.FirstOrDefault(klant => klant.Id == id));

    public Task<Klant> UpdateAsync(Klant klant)
    {
        var toUpdateKlant = _context.Klanten.FirstOrDefault(k => k.Id == klant.Id) ?? throw new Exception("Klant not found");
        toUpdateKlant.Name = toUpdateKlant.Name;
        toUpdateKlant.Projecten = toUpdateKlant.Projecten;
        _context.SaveChanges();
        return Task.FromResult(toUpdateKlant);
    }
}