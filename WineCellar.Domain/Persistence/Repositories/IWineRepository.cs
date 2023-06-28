namespace WineCellar.Domain.Persistence.Repositories;

public interface IWineRepository
{
    Task<List<Wine>> All();
    Task<Wine?> GetById(int id);
    Task<bool> Delete(int id);
    Task Update(Wine wine);
    Task<Wine> Create(Wine entity);
    Task AddGrapeToWine(int grapeId, int wineId);
    Task RemoveGrapeFromWine(int grapeId, int wineId);
    Task<Wine?> GetByName(string name);
    Task<List<Wine>> GetByWineryId(int wineryId);
}