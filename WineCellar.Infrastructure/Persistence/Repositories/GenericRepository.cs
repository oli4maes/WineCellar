namespace WineCellar.Infrastructure.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    internal DbSet<T> dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        dbSet = context.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> All()
    {
        return await dbSet.ToListAsync();
    }

    public virtual async Task<T> Create(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException();
        }

        await dbSet.AddAsync(entity);

        return entity;
    }

    public virtual Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<T> GetById(int id)
    {
        return await dbSet.FindAsync(id);
    }

    public virtual Task Update(T entity)
    {
        throw new NotImplementedException();
    }
}

