namespace WineCellar.Domain.Interfaces.Repositories;

public interface IWineRepository : IGenericRepository<Wine>
{
    Task AddGrapeToWine(int grapeId, int wineId);
    Task RemoveGrapeFromWine(int grapeId, int wineId);
    Task<IEnumerable<Wine>> GetByWineryId(int wineryId);
}