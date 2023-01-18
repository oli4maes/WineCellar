namespace WineCellar.Infrastructure.Persistence.Repositories;

public class WineRepository : GenericRepository<Wine>, IWineRepository
{
    public WineRepository(ApplicationDbContext context) : base(context)
    {
    }

    public override async Task<IEnumerable<Wine>> All()
    {
        return await DbSet.Include(x => x.Grapes)
                          .Include(x => x.Winery)
                          .AsNoTracking()
                          .ToListAsync();
    }

    public override async Task<bool> Delete(int id)
    {
        var wineModel = await DbSet.FirstOrDefaultAsync(x => x.Id == id);

        if (wineModel == null)
        {
            return false;
        }

        DbSet.Remove(wineModel);

        return true;
    }

    public override async Task Update(Wine wine)
    {
        var wineModel = await DbSet.Include(x => x.GrapeWines).FirstOrDefaultAsync(x => x.Id == wine.Id);

        if (wineModel == null)
        {
            throw new Exception("Couldn't find the wine to update");
        }

        wineModel.Name = wine.Name;
        wineModel.WineryId = wine.WineryId;
        wineModel.WineType = wine.WineType;
        wineModel.LastModified = DateTime.UtcNow;
        wineModel.LastModifiedBy = wine.LastModifiedBy;

        // Remove all grape wines and insert updated ones
        wineModel.GrapeWines.Clear();

        foreach (Grape grape in wine.Grapes)
        {
            wineModel.GrapeWines.Add(new GrapeWine { GrapesId = grape.Id, WinesId = wine.Id });
        }
    }

    public override async Task<Wine?> GetByName(string name)
    {
        return await DbSet.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
    }
}
