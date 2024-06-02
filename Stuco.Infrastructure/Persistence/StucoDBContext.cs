using Microsoft.EntityFrameworkCore;
using Stuco.Domain.Entities;

namespace Stuco.Infrastructure.Persistence;

internal class StucoDBContext : DbContext
{
    public StucoDBContext(DbContextOptions<StucoDBContext> options) : base(options)
    {
    }

    public DbSet<Stukadoor> Stukadoren { get; set; }
    public DbSet<Klant> Klanten { get; set; }
    public DbSet<Project> Projecten { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Project>()
            .HasOne(p => p.Klant)
            .WithMany(k => k.Projecten)
            .HasForeignKey(p => p.KlantId);

        modelBuilder.Entity<Stukadoor>()
            .HasOne(s => s.Project)
            .WithMany(p => p.Stukadoren)
            .HasForeignKey(s => s.ProjectId);
    }
}