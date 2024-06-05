using Microsoft.EntityFrameworkCore;
using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;
using Stuco.Infrastructure.Persistence;

namespace Stuco.Infrastructure.Repositories;

public class StukadoorRepository : IRepository<Stukadoor>
{
    private StucoDBContext _context;

    public StukadoorRepository(StucoDBContext context)
    {
        _context = context;
    }

    public Task<Stukadoor> AddAsync(Stukadoor stukadoor)
    {
        _context.Stukadoren.Add(stukadoor);
        _context.SaveChanges();
        return Task.FromResult(stukadoor);
    }

    public Task DeleteAsync(int id)
    {
        var stukadoor = _context.Stukadoren
            .Include(s => s.Project)
            .ToList()
            .FirstOrDefault(s => s.Id == id) ?? throw new Exception("Stukadoor not found");

        _context.Stukadoren.Remove(stukadoor);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

    public Task<List<Stukadoor>> GetAllAsync()
    {
        return Task.FromResult(_context.Stukadoren.ToList());
    }

    public Task<Stukadoor> GetByIdAsync(int id)
    {
        return Task.FromResult(_context.Stukadoren.
                Include(stukadoor => stukadoor.Project)
                .ToList()
                .FirstOrDefault(stukadoor => stukadoor.Id == id));
    }

    public Task<Stukadoor> UpdateAsync(Stukadoor stukadoor)
    {
        var toUpdateStukadoor = _context.Stukadoren
            .FirstOrDefault(s => s.Id == stukadoor.Id) ?? throw new Exception("Stukadoor not found");

        toUpdateStukadoor.Name = stukadoor.Name;
        toUpdateStukadoor.Project = stukadoor.Project;
        _context.SaveChanges();
        return Task.FromResult(toUpdateStukadoor);
    }
}