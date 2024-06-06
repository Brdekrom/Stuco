using Stuco.Domain.Abstractions;

namespace Stuco.Application.Abstractions;

public interface IRepository<T> where T : EntityBase
{
    Task<T> GetByIdAsync(int id);

    Task<List<T>> GetAllAsync();

    Task<T> AddAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task DeleteAsync(int id);
}