using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure.Persistence.Repositories;

public class WineRepository : IWineRepository
{
    private readonly ApplicationDbContext _context;

    public WineRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _context = dbContextFactory.CreateDbContext();
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        var wineModel = await _context.Wines.FirstOrDefaultAsync(x => x.Id == id);

        if (wineModel == null)
        {
            return false;
        }

        _context.Wines.Remove(wineModel);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task Update(Wine wine)
    {
        ArgumentNullException.ThrowIfNull(wine);

        var wineModel = await _context.Wines.Include(x => x.GrapeWines).FirstOrDefaultAsync(x => x.Id == wine.Id);

        if (wineModel == null)
        {
            throw new Exception("Couldn't find the wine to update");
        }

        wineModel.Name = wine.Name;
        wineModel.WineryId = wine.WineryId;
        wineModel.WineType = wine.WineType;
        wineModel.RegionId = wine.RegionId;
        wineModel.LastModified = DateTime.UtcNow;
        wineModel.LastModifiedBy = wine.LastModifiedBy;

        await _context.SaveChangesAsync();
    }

    public async Task<Wine> Create(Wine entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await _context.Wines.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task AddGrapeToWine(int grapeId, int wineId)
    {
        ArgumentNullException.ThrowIfNull(grapeId);
        ArgumentNullException.ThrowIfNull(wineId);

        var wine = _context.Wines
            .Include(x => x.GrapeWines)
            .Single(x => x.Id == wineId);

        var grape = _context.Grapes.Single(x => x.Id == grapeId);

        wine.GrapeWines.Add(new GrapeWine()
        {
            Grape = grape,
            WineId = wineId
        });

        await _context.SaveChangesAsync();
    }

    public async Task RemoveGrapeFromWine(int grapeId, int wineId)
    {
        ArgumentNullException.ThrowIfNull(grapeId);
        ArgumentNullException.ThrowIfNull(wineId);

        var wine = _context.Wines
            .Include(x => x.GrapeWines)
            .Single(x => x.Id == wineId);

        var grapeWineToDelete = wine.GrapeWines.Single(x => x.WineId == wineId && x.GrapeId == grapeId);

        wine.GrapeWines.Remove(grapeWineToDelete);

        await _context.SaveChangesAsync();
    }
}