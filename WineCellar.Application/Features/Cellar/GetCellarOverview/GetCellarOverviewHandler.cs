using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        var bottles = await _bottleRepository.GetUserBottlesInCellar(request.Auth0Id);
        var groupedByWine = bottles.GroupBy(x => x.WineId);
        var winesInCellar = new List<GetCellarOverviewResponse.CellarOverviewDto>();

        foreach (var group in groupedByWine)
        {
            winesInCellar.Add(new GetCellarOverviewResponse.CellarOverviewDto()
            {
                WineId = group.Key,
                WineName = group.First().Wine.Name,
                WineryName = group.First().Wine.Winery.Name,
                RegionName = group.First().Wine.Region?.Name,
                WineType = group.First().Wine.WineType,
                Amount = GetAmount(group)
            });
        }

        return new GetCellarOverviewResponse()
        {
            Bottles = winesInCellar
        };
    }

    private int GetAmount(IGrouping<int, Bottle> grouping)
    {
        return grouping.Count();
    }
}