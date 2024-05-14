using Microsoft.EntityFrameworkCore;
using Stuco.Domain.Entities;

namespace Stuco.Infrastructure.Persistence;

internal class StucoDBContext : DbContext
{
    public StucoDBContext(DbContextOptions<StucoDBContext> options) : base(options)
    {
    }

    public DbSet<Stukadoor> Stukadoors { get; set; }
    public DbSet<Klant> Klanten { get; set; }
    public DbSet<Project> Projecten { get; set; }
}