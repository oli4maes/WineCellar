using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Regions.GetRegionsByCountry;

internal sealed class
    GetRegionsByCountryHandler : IRequestHandler<GetRegionsByCountryRequest, GetRegionsByCountryResponse>
{
    private readonly IRegionRepository _regionRepository;


    public GetRegionsByCountryHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async ValueTask<GetRegionsByCountryResponse> Handle(GetRegionsByCountryRequest request,
        CancellationToken cancellationToken)
    {
        var regions = await _regionRepository.GetByCountry(request.CountryId);

        return new GetRegionsByCountryResponse()
        {
            Regions = regions.Select(x => new RegionDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList()
        };
    }
}