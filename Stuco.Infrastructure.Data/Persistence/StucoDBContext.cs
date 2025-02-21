using Microsoft.EntityFrameworkCore;
using Stuco.Domain.Entities;

namespace Stuco.Infrastructure.Persistence;

public class StucoDBContext : DbContext
{
    public StucoDBContext(DbContextOptions<StucoDBContext> options) : base(options)
    {
    }
    
    public DbSet<Contractor> Contractors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}