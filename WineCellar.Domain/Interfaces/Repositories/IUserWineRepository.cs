namespace WineCellar.Domain.Interfaces.Repositories;

public interface IUserWineRepository : IGenericRepository<UserWine>
{
    // Get only the logged-in user's wines
    Task<IEnumerable<UserWine>> GetUserWines(string auth0Id);
    
    // Get by wine id
    Task<UserWine?> GetByWineId(int wineId);
}
