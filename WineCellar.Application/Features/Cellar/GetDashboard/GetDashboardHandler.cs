using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.GetDashboard;

internal sealed class GetDashboardHandler : IRequestHandler<GetDashboardRequest, GetDashboardResponse>
{
    private readonly IUserWineRepository _userWineRepository;

    public GetDashboardHandler(IUserWineRepository userWineRepository)
    {
        _userWineRepository = userWineRepository;
    }

    public async ValueTask<GetDashboardResponse> Handle(GetDashboardRequest request,
        CancellationToken cancellationToken)
    {
        var uWines = await _userWineRepository.GetUserWines(request.Auth0Id);
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
        var favouriteWineType = GetFavouriteWineType(wineTypeDict);

        var amountOfBottlesPerWineTypeLabels = new[]
            { nameof(WineType.White), nameof(WineType.Rosé), nameof(WineType.Red), nameof(WineType.Sparkling) };

        var favouriteWine = GetFavouriteWine(userWines);
        var favouriteWineName = favouriteWine?.Name;

        var groupedByWinery = userWines.GroupBy(x => x.Wine!.WineryId);
        var favouriteWineryId = GetFavouriteWinery(groupedByWinery);
        var favouriteWinery = userWines.First(x => x.Wine?.WineryId == favouriteWineryId).Wine?.Winery;
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

    private double GetAmountOfBottles(List<UserWine> wines)
    {
        var amount = 0d;

        foreach (var wine in wines)
        {
            amount += wine.Amount;
        }

        return amount;
    }

    private WineType GetFavouriteWineType(Dictionary<WineType, double> dict)
    {
        return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }

    private Wine? GetFavouriteWine(List<UserWine> userWines)
    {
        return userWines.Aggregate((agg, next) => next.Amount > agg.Amount ? next : agg).Wine;
    }

    private int? GetFavouriteWinery(IEnumerable<IGrouping<int, UserWine>> grouping)
    {
        var dict = new Dictionary<int, int>();

        foreach (var x in grouping)
        {
            var amount = 0;

            foreach (var uw in x)
            {
                amount += uw.Amount;
            }

            dict.Add(x.Key, amount);
        }

        return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }
}