namespace WineCellar.Application.Features.Countries.GetCountries;

public class GetCountriesResponse
{
    public List<CountryDto> Countries { get; set; } = new();
}