using Microsoft.EntityFrameworkCore;
using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;
using Stuco.Infrastructure.Persistence;

namespace Stuco.Infrastructure.Repositories;

public class ProjectRepository : IRepository<Project>
{
    private StucoDBContext _context;

    public ProjectRepository(StucoDBContext context)
    {
        _context = context;
    }

    public Task<Project> AddAsync(Project project)
    {
        _context.Projecten.Add(project);
        _context.SaveChanges();
        return Task.FromResult(project);
    }

    public Task DeleteAsync(int id)
    {
        var project = _context.Projecten
            .Include(x => x.Stukadoren)
            .ToList()
            .FirstOrDefault(p => p.Id == id) ?? throw new Exception("Stukadoor not found");
        _context.Projecten.Remove(project);
        _context.SaveChanges();
        return Task.CompletedTask;
    }

    public Task<List<Project>> GetAllAsync()
    {
        return Task.FromResult(_context.Projecten.ToList());
    }

    public Task<Project> GetByIdAsync(int id)
        => Task.FromResult(_context.Projecten
            .Include(x => x.Stukadoren)
            .ToList()
            .FirstOrDefault(project => project.Id == id));

    public Task<Project> UpdateAsync(Project projecten)
    {
        var toUpdateProject = _context.Projecten
            .Include(x => x.Stukadoren)
            .ToList()
            .FirstOrDefault(p => p.Id == projecten.Id) ?? throw new Exception("Stukadoor not found");
        toUpdateProject.Name = projecten.Name;
        toUpdateProject.Stukadoren = projecten.Stukadoren;
        _context.Projecten.Update(toUpdateProject);
        _context.SaveChanges();
        return Task.FromResult(toUpdateProject);
    }
}