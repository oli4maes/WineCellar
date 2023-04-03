namespace WineCellar.Domain.Persistence.Repositories;

public interface IWineRepository : IGenericRepository<Wine>
{
    Task AddGrapeToWine(int grapeId, int wineId);
    Task RemoveGrapeFromWine(int grapeId, int wineId);
    Task<List<Wine>> GetByWineryId(int wineryId);
    Task<List<Wine>> GetAllSpotlit();
    Task<bool> ToggleIsSpotlit(int id, string userName);
}