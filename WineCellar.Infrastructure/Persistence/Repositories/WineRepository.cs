namespace WineCellar.Infrastructure.Persistence.Repositories;

public class WineRepository : GenericRepository<Wine>, IWineRepository
{
    public WineRepository(ApplicationDbContext context) : base(context)
    {
    }

    public override async Task<bool> Delete(int id)
    {
        var wineModel = await dbSet.FirstOrDefaultAsync(x => x.Id == id);

        if (wineModel == null)
        {
            return false;
        }

        dbSet.Remove(wineModel);

        return true;
    }

    public override async Task Update(Wine wine)
    {
        var wineModel = await dbSet.FirstOrDefaultAsync(x => x.Id == wine.Id);

        if (wineModel == null)
        {
            throw new Exception("Couldn't find the wine to update");
        }

        wineModel.Name = wine.Name;
        wineModel.WineryId = wine.WineryId;
        wineModel.WineType = wine.WineType;
        wineModel.LastModified = DateTime.UtcNow;
        wineModel.LastModifiedBy = wine.LastModifiedBy;
    }

    public override async Task<Wine> GetByName(string name)
    {
        return await dbSet.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
    }
}
