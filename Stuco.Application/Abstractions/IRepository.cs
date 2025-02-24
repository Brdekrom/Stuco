using Microsoft.EntityFrameworkCore;
using Stuco.Domain.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Abstractions;

public interface IRepository
{
    DbSet<Contractor> Contractors { get; }

    Task<int> SaveChangesAsync();
}