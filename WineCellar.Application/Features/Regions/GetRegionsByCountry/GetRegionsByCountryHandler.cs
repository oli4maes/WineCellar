using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Regions.GetRegionsByCountry;

internal sealed class
    GetRegionsByCountryHandler : IRequestHandler<GetRegionsByCountryRequest, GetRegionsByCountryResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetRegionsByCountryHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetRegionsByCountryResponse> Handle(GetRegionsByCountryRequest request,
        CancellationToken cancellationToken)
    {
        var regions = _queryFacade.Regions.Where(x => x.CountryId == request.CountryId);

        return new GetRegionsByCountryResponse()
        {
            Regions = await regions.Select(x => new RegionDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync(cancellationToken)
        };
    }
}