using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure.Persistence.Repositories;

public class BottleRepository : IBottleRepository
{
    private readonly ApplicationDbContext _context;

    public BottleRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _context = dbContextFactory.CreateDbContext();
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        var userWineModel = await _context.Bottles!
            .FirstOrDefaultAsync(x => x.Id == id);

        if (userWineModel == null)
        {
            return false;
        }

        _context.Bottles.Remove(userWineModel);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<List<Bottle>> GetUserBottles(string auth0Id)
    {
        ArgumentException.ThrowIfNullOrEmpty(auth0Id);

        return await _context.Bottles
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

        return await _context.Bottles
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .Include(w => w.Wine.Region)
            .Where(x => x.Auth0Id == auth0Id && x.Status == BottleStatus.InCellar)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task Update(Bottle bottle)
    {
        ArgumentNullException.ThrowIfNull(bottle);

        var userWineModel = await _context.Bottles
            .FirstOrDefaultAsync(x => x.Id == bottle.Id);

        if (userWineModel == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        userWineModel.BottleSize = bottle.BottleSize;
        userWineModel.Vintage = bottle.Vintage;
        userWineModel.LastModified = DateTime.UtcNow;
        userWineModel.LastModifiedBy = bottle.LastModifiedBy;

        await _context.SaveChangesAsync();
    }

    public async Task<Bottle> Create(Bottle entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await _context.Bottles.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task SetStatus(int id, BottleStatus status, string userName)
    {
        ArgumentNullException.ThrowIfNull(id);

        var userWineModel = await _context.Bottles
            .FirstOrDefaultAsync(x => x.Id == id);

        if (userWineModel == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        userWineModel.Status = status;
        userWineModel.LastModified = DateTime.UtcNow;
        userWineModel.LastModifiedBy = userName;

        await _context.SaveChangesAsync();
    }
}