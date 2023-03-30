namespace WineCellar.Infrastructure.Persistence.Repositories;

public class WineRepository : IWineRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public WineRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<IEnumerable<Wine>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Wines
            .Include(x => x.Country)
            .Include(x => x.Winery)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Wine?> GetById(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Wines
            .Include(x => x.Country)
            .Include(x => x.Winery)
            .Include(x => x.Grapes)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var wineModel = await context.Wines.FirstOrDefaultAsync(x => x.Id == id);

        if (wineModel == null)
        {
            return false;
        }

        context.Wines.Remove(wineModel);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task Update(Wine wine)
    {
        ArgumentNullException.ThrowIfNull(wine);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var wineModel = await context.Wines.Include(x => x.GrapeWines).FirstOrDefaultAsync(x => x.Id == wine.Id);

        if (wineModel == null)
        {
            throw new Exception("Couldn't find the wine to update");
        }

        wineModel.Name = wine.Name;
        wineModel.WineryId = wine.WineryId;
        wineModel.WineType = wine.WineType;
        wineModel.CountryId = wine.CountryId;
        wineModel.LastModified = DateTime.UtcNow;
        wineModel.LastModifiedBy = wine.LastModifiedBy;

        await context.SaveChangesAsync();
    }

    public async Task<Wine> Create(Wine entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        await context.Wines.AddAsync(entity);
        await context.SaveChangesAsync();

        return entity;
    }

    public async Task AddGrapeToWine(int grapeId, int wineId)
    {
        ArgumentNullException.ThrowIfNull(grapeId);
        ArgumentNullException.ThrowIfNull(wineId);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var wine = context.Wines
            .Include(x => x.GrapeWines)
            .Single(x => x.Id == wineId);

        var grape = context.Grapes.Single(x => x.Id == grapeId);

        wine.GrapeWines.Add(new GrapeWine()
        {
            Grape = grape,
            WineId = wineId
        });

        await context.SaveChangesAsync();
    }

    public async Task RemoveGrapeFromWine(int grapeId, int wineId)
    {
        ArgumentNullException.ThrowIfNull(grapeId);
        ArgumentNullException.ThrowIfNull(wineId);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var wine = context.Wines
            .Include(x => x.GrapeWines)
            .Single(x => x.Id == wineId);

        var grapeWineToDelete = wine.GrapeWines.Single(x => x.WineId == wineId && x.GrapeId == grapeId);

        wine.GrapeWines.Remove(grapeWineToDelete);

        await context.SaveChangesAsync();
    }

    public async Task<Wine?> GetByName(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Wines
            .FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
    }

    public async Task<IEnumerable<Wine>> GetByWineryId(int wineryId)
    {
        ArgumentNullException.ThrowIfNull(wineryId);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Wines
            .Where(x => x.WineryId == wineryId)
            .AsNoTracking()
            .ToListAsync();
    }
}