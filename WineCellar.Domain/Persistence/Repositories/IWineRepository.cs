namespace WineCellar.Domain.Persistence.Repositories;

public interface IWineRepository
{
    Task<bool> Delete(int id);
    Task Update(Wine wine);
    Task<Wine> Create(Wine entity);
    Task AddGrapeToWine(int grapeId, int wineId);
    Task RemoveGrapeFromWine(int grapeId, int wineId);
}