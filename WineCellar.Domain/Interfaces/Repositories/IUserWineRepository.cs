namespace WineCellar.Domain.Interfaces.Repositories;

public interface IUserWineRepository : IGenericRepository<UserWine>
{
    // Get Only The Logged-In User's Wines
    Task<IEnumerable<UserWine>> GetUserWines(string auth0Id);
}
