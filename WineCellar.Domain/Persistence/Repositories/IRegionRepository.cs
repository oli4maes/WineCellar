namespace WineCellar.Domain.Persistence.Repositories;

public interface IRegionRepository : IGenericRepository<Region>
{
    Task<List<Region>> GetByCountry(int countryId);
    Task<bool> ToggleIsSpotlit(int id, string userName);
}