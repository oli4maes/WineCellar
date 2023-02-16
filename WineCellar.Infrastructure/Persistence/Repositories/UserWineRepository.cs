namespace WineCellar.Infrastructure.Persistence.Repositories;

public class UserWineRepository : IUserWineRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public UserWineRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<IEnumerable<UserWine>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<UserWine?> GetById(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public Task<UserWine?> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var userWineModel = await context.UserWines!
            .FirstOrDefaultAsync(x => x.Id == id);

        if (userWineModel == null)
        {
            return false;
        }

        context.UserWines!.Remove(userWineModel);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<UserWine>> GetUserWines(string auth0Id)
    {
        ArgumentException.ThrowIfNullOrEmpty(auth0Id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .Where(x => x.Auth0Id == auth0Id)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<UserWine?> GetByWineId(int wineId)
    {
        ArgumentNullException.ThrowIfNull(wineId);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Wine.Id == wineId);
    }

    public async Task Update(UserWine userWine)
    {
        ArgumentNullException.ThrowIfNull(userWine);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var userWineModel = await context.UserWines!
            .FirstOrDefaultAsync(x => x.Id == userWine.Id);

        if (userWineModel == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        userWine.WineId = userWineModel.Id;
        userWine.Amount = userWineModel.Amount;
        userWine.LastModified = DateTime.UtcNow;
        userWine.LastModifiedBy = userWineModel.LastModifiedBy;

        await context.SaveChangesAsync();
    }

    public async Task<UserWine> Create(UserWine entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        await context.UserWines!.AddAsync(entity);
        await context.SaveChangesAsync();

        return entity;
    }
}