using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Countries.GetCountries;

internal sealed class GetCountriesHandler : IRequestHandler<GetCountriesRequest, GetCountriesResponse>
{
    private readonly IQueryFacade _queryFacade;


    public GetCountriesHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetCountriesResponse> Handle(GetCountriesRequest request,
        CancellationToken cancellationToken)
    {
        var countries = _queryFacade.Countries;

        return new GetCountriesResponse()
        {
            Countries = await countries.Select(x => new CountryDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync(cancellationToken)
        };
    }
}