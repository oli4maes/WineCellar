namespace WineCellar.Domain.Persistence.Repositories;

public interface ICountryRepository
{
    Task<List<Country>> All();
}