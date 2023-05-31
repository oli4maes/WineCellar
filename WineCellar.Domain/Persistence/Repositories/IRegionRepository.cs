namespace WineCellar.Domain.Persistence.Repositories;

public interface IRegionRepository : IGenericRepository<Region>
{
    Task<List<Region>> GetByCountry(int countryId);
}