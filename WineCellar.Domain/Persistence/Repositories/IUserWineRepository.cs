namespace WineCellar.Domain.Persistence.Repositories;

public interface IUserWineRepository : IGenericRepository<UserWine>
{
    // Get only the logged-in user's wines
    Task<List<UserWine>> GetUserWines(string auth0Id);
    
    // Get by wine id
    Task<UserWine?> GetByWineId(int wineId, string auth0Id);
}
