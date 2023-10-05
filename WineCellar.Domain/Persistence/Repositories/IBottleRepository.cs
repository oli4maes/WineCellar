using WineCellar.Domain.Enums;

namespace WineCellar.Domain.Persistence.Repositories;

public interface IBottleRepository
{
    Task<bool> Delete(int id);
    Task<List<Bottle>> GetUserBottles(string auth0Id);
    Task<List<Bottle>> GetUserBottlesInCellar(string auth0Id);
    Task Update(Bottle bottle);
    Task<Bottle> Create(Bottle entity);
    Task SetStatus(int id, BottleStatus status, string userName);
}