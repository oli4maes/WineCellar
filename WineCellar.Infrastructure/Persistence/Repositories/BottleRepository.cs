using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure.Persistence.Repositories;

public class BottleRepository : IBottleRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public BottleRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<Bottle?> GetById(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Bottles!
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var userWineModel = await context.Bottles!
            .FirstOrDefaultAsync(x => x.Id == id);

        if (userWineModel == null)
        {
            return false;
        }

        context.Bottles.Remove(userWineModel);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<List<Bottle>> GetUserBottles(string auth0Id)
    {
        ArgumentException.ThrowIfNullOrEmpty(auth0Id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Bottles
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .Include(w => w.Wine.Region)
            .Where(x => x.Auth0Id == auth0Id)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<Bottle>> GetByWineId(int wineId, string auth0Id)
    {
        ArgumentNullException.ThrowIfNull(wineId);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Bottles
            .Include(x => x.Wine)
            .ThenInclude(w => w!.Winery)
            .AsNoTracking()
            .Where(x => x.Wine.Id == wineId && x.Auth0Id == auth0Id)
            .ToListAsync();
    }

    public async Task Update(Bottle bottle)
    {
        ArgumentNullException.ThrowIfNull(bottle);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var userWineModel = await context.Bottles
            .FirstOrDefaultAsync(x => x.Id == bottle.Id);

        if (userWineModel == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        userWineModel.BottleSize = bottle.BottleSize;
        userWineModel.Vintage = bottle.Vintage;
        userWineModel.LastModified = DateTime.UtcNow;
        userWineModel.LastModifiedBy = bottle.LastModifiedBy;

        await context.SaveChangesAsync();
    }

    public async Task<Bottle> Create(Bottle entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        await context.Bottles.AddAsync(entity);
        await context.SaveChangesAsync();

        return entity;
    }
}