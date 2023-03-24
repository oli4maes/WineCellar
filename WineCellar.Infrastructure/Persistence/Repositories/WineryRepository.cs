namespace WineCellar.Infrastructure.Persistence.Repositories;

public class WineryRepository : IWineryRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public WineryRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var wineryModel = await context.Wineries.FirstOrDefaultAsync(x => x.Id == id);

        if (wineryModel == null)
        {
            return false;
        }

        context.Wineries.Remove(wineryModel);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task Update(Winery winery)
    {
        ArgumentNullException.ThrowIfNull(winery);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var wineryModel = await context.Wineries.FirstOrDefaultAsync(x => x.Id == winery.Id);

        if (wineryModel == null)
        {
            throw new Exception("Couldn't find the winery to update");
        }

        wineryModel.Name = winery.Name;
        wineryModel.Description = winery.Description;
        wineryModel.LastModified = DateTime.UtcNow;
        wineryModel.LastModifiedBy = winery.LastModifiedBy;

        await context.SaveChangesAsync();
    }

    public async Task<Winery> Create(Winery entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        await context.Wineries.AddAsync(entity);
        await context.SaveChangesAsync();

        return entity;
    }

    public async Task<IEnumerable<Winery>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Wineries.AsNoTracking().ToListAsync();
    }

    public async Task<Winery?> GetById(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Wineries.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Winery?> GetByName(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Wineries.AsNoTracking().FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
    }
}