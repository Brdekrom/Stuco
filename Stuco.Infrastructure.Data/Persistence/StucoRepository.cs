using Microsoft.EntityFrameworkCore;
using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Infrastructure.Persistence;

public class StucoRepository(StucoDBContext context) : IRepository
{
    public DbSet<Contractor> Contractors  => context.Contractors;
    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}