using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Countries.GetCountries;

internal sealed class GetCountriesHandler : IRequestHandler<GetCountriesRequest, GetCountriesResponse>
{
    private readonly ICountryRepository _countryRepository;

    public GetCountriesHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    public async ValueTask<GetCountriesResponse> Handle(GetCountriesRequest request,
        CancellationToken cancellationToken)
    {
        var countries = await _countryRepository.All();

        return new GetCountriesResponse()
        {
            Countries = countries.Select(x => new CountryDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList()
        };
    }
}