namespace WineCellar.Domain.Persistence.Repositories;

public interface IRegionRepository
{
    Task<List<Region>> GetByCountry(int countryId);
}