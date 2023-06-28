namespace WineCellar.Domain.Persistence.Repositories;

public interface IBottleRepository
{
    Task<List<Bottle>> All();
    Task<Bottle?> GetById(int id);
    Task<bool> Delete(int id);
    Task<List<Bottle>> GetUserBottles(string auth0Id);
    Task<List<Bottle>> GetByWineId(int wineId, string auth0Id);
    Task Update(Bottle bottle);
    Task<Bottle> Create(Bottle entity);
}