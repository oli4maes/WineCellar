using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.GetDashboard;

internal sealed class GetDashboardHandler : IRequestHandler<GetDashboardRequest, GetDashboardResponse>
{
    private readonly IBottleRepository _bottleRepository;

    public GetDashboardHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<GetDashboardResponse> Handle(GetDashboardRequest request,
        CancellationToken cancellationToken)
    {
        var uWines = await _bottleRepository.GetUserBottles(request.Auth0Id);
        var userWines = uWines.ToList();

        var whites = userWines.Where(x => x.Wine?.WineType == WineType.White);
        var amountOfWhites = GetAmountOfBottles(whites.ToList());

        var roses = userWines.Where(x => x.Wine?.WineType == WineType.Rosé);
        var amountOfRoses = GetAmountOfBottles(roses.ToList());

        var reds = userWines.Where(x => x.Wine?.WineType == WineType.Red);
        var amountOfReds = GetAmountOfBottles(reds.ToList());

        var sparkling = userWines.Where(x => x.Wine?.WineType == WineType.Sparkling);
        var amountOfSparkling = GetAmountOfBottles(sparkling.ToList());

        var amountOfBottlesPerWineTypeData = new[] { amountOfWhites, amountOfRoses, amountOfReds, amountOfSparkling };

        var wineTypeDict = new Dictionary<WineType, double>
        {
            { WineType.White, amountOfWhites },
            { WineType.Rosé, amountOfRoses },
            { WineType.Red, amountOfReds },
            { WineType.Sparkling, amountOfSparkling }
        };

        WineType? favouriteWineType = null;
        if (userWines.Any())
        {
            favouriteWineType = GetFavouriteWineType(wineTypeDict);
        }

        var amountOfBottlesPerWineTypeLabels = new[]
            { nameof(WineType.White), nameof(WineType.Rosé), nameof(WineType.Red), nameof(WineType.Sparkling) };

        var favouriteWine = new Wine();
        if (userWines.Any())
        {
            favouriteWine = GetFavouriteWine(userWines);
        }

        var favouriteWineName = favouriteWine?.Name;

        var groupedByWinery = userWines.GroupBy(x => x.Wine!.WineryId);
        var favouriteWineryId = GetFavouriteWinery(groupedByWinery);

        var favouriteWinery = new Winery();
        if (userWines.Any())
        {
            favouriteWinery = userWines.First(x => x.Wine?.WineryId == favouriteWineryId).Wine?.Winery;
        }

        var favouriteWineryName = favouriteWinery?.Name;

        return new GetDashboardResponse()
        {
            AmountOfBottlesInCellar =
                Convert.ToInt32(amountOfWhites + amountOfRoses + amountOfReds + amountOfSparkling),
            AmountOfBottlesPerWineTypeData = amountOfBottlesPerWineTypeData,
            AmountOfBottlesPerWineTypeLabels = amountOfBottlesPerWineTypeLabels,
            FavouriteWineType = favouriteWineType,
            AmountOfBottlesPerWineType = wineTypeDict,
            FavouriteWine = favouriteWineName ?? string.Empty,
            FavouriteWineId = favouriteWine?.Id,
            FavouriteWinery = favouriteWineryName ?? string.Empty,
            FavouriteWineryId = favouriteWineryId
        };
    }

    private double GetAmountOfBottles(List<Bottle> bottles)
    {
        var amount = 0d;

        foreach (var bottle in bottles)
        {
            amount += 1;
        }

        return amount;
    }

    private WineType GetFavouriteWineType(Dictionary<WineType, double> dict)
    {
        return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }

    private Wine GetFavouriteWine(List<Bottle> bottles)
    {
        //return bottles.Aggregate((agg, next) => next.Amount > agg.Amount ? next : agg).Wine;
        return new Wine();
    }

    private int? GetFavouriteWinery(IEnumerable<IGrouping<int, Bottle>> grouping)
    {
        if (grouping.Any())
        {
            var dict = new Dictionary<int, int>();

            foreach (var x in grouping)
            {
                var amount = 0;

                foreach (var uw in x)
                {
                    amount += 1;
                }

                dict.Add(x.Key, amount);
            }

            return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }

        return null;
    }
}