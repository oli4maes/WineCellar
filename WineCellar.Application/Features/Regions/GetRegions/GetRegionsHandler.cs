using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Regions.GetRegions;

internal sealed class GetRegionsHandler : IRequestHandler<GetRegionsRequest, GetRegionsResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetRegionsHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetRegionsResponse> Handle(GetRegionsRequest request, CancellationToken cancellationToken)
    {
        var regions = _queryFacade.Regions;

        if (request.Query is not null)
        {
            regions = regions
                .Where(x => x.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase));
        }

        return new GetRegionsResponse()
        {
            Regions = await regions.Select(x => new RegionDto()
            {
                Id = x.Id,
                Name = x.Name,
                CountryName = x.Country.Name
            }).ToListAsync(cancellationToken)
        };
    }
}