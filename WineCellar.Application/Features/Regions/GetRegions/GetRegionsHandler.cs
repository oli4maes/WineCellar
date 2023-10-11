using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Regions.GetRegions;

internal sealed class GetRegionsHandler : IRequestHandler<GetRegionsRequest, GetRegionsResponse>
{
    private readonly IRegionRepository _regionRepository;

    public GetRegionsHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async ValueTask<GetRegionsResponse> Handle(GetRegionsRequest request, CancellationToken cancellationToken)
    {
        var regions = await _regionRepository.All();

        if (request.Query is not null)
        {
            regions = regions
                .Where(x => x.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        return new GetRegionsResponse()
        {
            Regions = regions.Select(x => new RegionDto()
            {
                Id = x.Id,
                Name = x.Name,
                CountryName = x.Country.Name
            }).ToList()
        };
    }
}