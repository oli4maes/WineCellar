namespace WineCellar.Infrastructure.Persistence.Repositories;

public class WineryRepository : GenericRepository<Winery>, IWineryRepository
{
	public WineryRepository(ApplicationDbContext context) : base(context)
	{
	}

	public override async Task<bool> Delete(int id)
	{
		var wineryModel = await DbSet.FirstOrDefaultAsync(x => x.Id == id);

		if (wineryModel == null)
		{
			return false;
		}

		DbSet.Remove(wineryModel);

		return true;
	}

	public override async Task Update(Winery winery)
	{
		var wineryModel = await DbSet.FirstOrDefaultAsync(x => x.Id == winery.Id);

		if (wineryModel == null)
		{
			throw new Exception("Couldn't find the winery to update");
		}

		wineryModel.Name= winery.Name;
		wineryModel.Description= winery.Description;
		wineryModel.LastModified = DateTime.UtcNow;
		wineryModel.LastModifiedBy = winery.LastModifiedBy;
	}

	public override async Task<Winery?> GetByName(string name)
	{
		return await DbSet.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
	}
}
