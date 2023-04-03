namespace WineCellar.Domain.Persistence.Repositories;

public interface IWineryRepository : IGenericRepository<Winery>
{
    Task<bool> ToggleIsSpotlit(int id, string userName);

    Task<List<Winery>> GetAllSpotlit();
}