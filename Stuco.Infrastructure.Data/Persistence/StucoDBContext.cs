using Microsoft.EntityFrameworkCore;
using Stuco.Domain.Entities;

namespace Stuco.Infrastructure.Persistence;

public class StucoDbContext(DbContextOptions<StucoDbContext> options) : DbContext(options)
{
    public DbSet<Contractor> Contractors { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ExecutedAssignment> ExecutedAssignments { get; set; }
    public DbSet<FiscalInformation> FiscalInformations { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Contractor)
            .WithMany(c => c.Invoices)
            .HasForeignKey("ContractorId")
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Client)
            .WithMany()
            .HasForeignKey("ClientId")
            .OnDelete(DeleteBehavior.NoAction); 
        
        base.OnModelCreating(modelBuilder);
    }
}