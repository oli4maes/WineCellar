namespace WineCellar.Domain.Persistence.Repositories;

public interface IWineryRepository
{
    Task<bool> Delete(int id);
    Task Update(Winery winery);
    Task<Winery> Create(Winery entity);
    Task<List<Winery>> All();
    Task<Winery?> GetById(int id);
    Task<Winery?> GetByName(string name);
    Task<bool> ToggleIsSpotlit(int id, string userName);
}