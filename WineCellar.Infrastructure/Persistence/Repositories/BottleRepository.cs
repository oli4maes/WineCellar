using WineCellar.Domain.Enums;
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

    public async Task<List<Bottle>> GetUserBottlesInCellar(string auth0Id)
    {
        ArgumentException.ThrowIfNullOrEmpty(auth0Id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Bottles
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .Include(w => w.Wine.Region)
            .Where(x => x.Auth0Id == auth0Id && x.Status == BottleStatus.InCellar)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<Bottle>> GetByWineId(int wineId, string auth0Id)
    {
        ArgumentNullException.ThrowIfNull(wineId);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Bottles
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .AsNoTracking()
            .Where(x => x.Wine.Id == wineId && x.Auth0Id == auth0Id)
            .ToListAsync();
    }

    public async Task Update(Bottle bottle)
    {
        ArgumentNullException.ThrowIfNull(bottle);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var bottleModel = await context.Bottles
            .FirstOrDefaultAsync(x => x.Id == bottle.Id);

        if (bottleModel == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        bottleModel.BottleSize = bottle.BottleSize;
        bottleModel.Vintage = bottle.Vintage;
        bottleModel.AddedOn = bottle.AddedOn;
        bottleModel.LastModified = DateTime.UtcNow;
        bottleModel.LastModifiedBy = bottle.LastModifiedBy;

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

    public async Task SetStatus(int id, BottleStatus status, DateTime consumedOn, string userName)
    {
        ArgumentNullException.ThrowIfNull(id);
        ArgumentNullException.ThrowIfNull(status);
        ArgumentNullException.ThrowIfNull(consumedOn);
        ArgumentNullException.ThrowIfNull(userName);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var bottle = await context.Bottles
            .FirstOrDefaultAsync(x => x.Id == id);

        if (bottle == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        bottle.Status = status;
        bottle.LastModified = DateTime.UtcNow;
        bottle.ConsumedOn = consumedOn;
        bottle.LastModifiedBy = userName;

        await context.SaveChangesAsync();
    }
}