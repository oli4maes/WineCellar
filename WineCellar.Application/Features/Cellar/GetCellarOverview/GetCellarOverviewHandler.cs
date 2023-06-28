using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.GetCellarOverview;

internal sealed class GetCellarOverviewHandler : IRequestHandler<GetCellarOverviewRequest, GetCellarOverviewResponse>
{
    private readonly IBottleRepository _bottleRepository;

    public GetCellarOverviewHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<GetCellarOverviewResponse> Handle(GetCellarOverviewRequest request,
        CancellationToken cancellationToken)
    {
        var bottles = await _bottleRepository.GetUserBottles(request.Auth0Id);

        return new GetCellarOverviewResponse()
        {
            Bottles = bottles.Select(x => new GetCellarOverviewResponse.CellarOverviewDto()
            {
                Id = x.Id,
                WineId = x.WineId,
                Vintage = x.Vintage,
                BottleSize = x.BottleSize,
                WineName = x.Wine.Name,
                WineType = x.Wine.WineType,
                WineryName = x.Wine.Winery.Name,
                RegionName = x.Wine.Region.Name
            })
        };
    }
}