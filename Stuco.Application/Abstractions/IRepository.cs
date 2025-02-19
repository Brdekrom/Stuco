using Stuco.Domain.Abstractions;

namespace Stuco.Application.Abstractions;

public interface IRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id);

    Task<List<T>> GetAllAsync();

    Task<T> AddAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task DeleteAsync(int id);
}