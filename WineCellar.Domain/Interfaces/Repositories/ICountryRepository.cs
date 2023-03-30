namespace WineCellar.Domain.Interfaces.Repositories;

public interface ICountryRepository
{
    Task<List<Country>> All();
}