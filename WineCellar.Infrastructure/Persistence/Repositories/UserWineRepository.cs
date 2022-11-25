namespace WineCellar.Infrastructure.Persistence.Repositories;

public class UserWineRepository : GenericRepository<UserWine>, IUserWineRepository
{
    public UserWineRepository(ApplicationDbContext context) : base(context)
    {
    }

    public override async Task<bool> Delete(int id)
    {
        var userWineModel = await dbSet.FirstOrDefaultAsync(x => x.Id == id);

        if (userWineModel == null)
        {
            return false;
        }

        dbSet.Remove(userWineModel);

        return true;
    }

    public async Task<IEnumerable<UserWine>> GetUserWines(string auth0Id)
    {
        return await dbSet.Where(x => x.Auth0Id == auth0Id).AsNoTracking().ToListAsync();
    }

    public override async Task Update(UserWine userWine)
    {
        var userWineModel = await dbSet.FirstOrDefaultAsync(x => x.Id == userWine.Id);

        if (userWineModel == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        userWine.WineId = userWineModel.Id;
        userWine.Amount = userWineModel.Amount;
        userWine.LastModified = DateTime.UtcNow;
        userWine.LastModifiedBy = userWineModel.LastModifiedBy;
    }
}
