namespace WineCellar.Domain.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class
{
    // Get all entities
    Task<IEnumerable<T>> All();

    // Get specific entity by id
    Task<T?> GetById(int id);

    // Get specific entity by name
    Task<T?> GetByName(string name);

    // Delete entity
    Task<bool> Delete(int id);

    // Update entity
    Task Update(T entity);

    // Create entity
    Task<T> Create(T entity);
}
