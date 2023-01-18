namespace WineCellar.Infrastructure.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    internal DbSet<T> DbSet;

    protected GenericRepository(ApplicationDbContext context)
    {
        DbSet = context.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> All()
    {
        return await DbSet.AsNoTracking().ToListAsync();
    }

    public virtual async Task<T> Create(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException();
        }

        await DbSet.AddAsync(entity);

        return entity;
    }

    public virtual Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<T?> GetById(int id)
    {
        return await DbSet.FindAsync(id);
    }

    public virtual Task<T?> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public virtual Task Update(T entity)
    {
        throw new NotImplementedException();
    }
}

