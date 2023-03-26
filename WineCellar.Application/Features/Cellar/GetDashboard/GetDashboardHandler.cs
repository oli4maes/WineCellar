using WineCellar.Domain.Enums;

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
        var userWines = await _userWineRepository.GetUserWines(request.Auth0Id);

        var whites = userWines.Where(x => x.Wine?.WineType == WineType.White);
        var amountOfWhites = GetAmountOfBottles(whites.ToList());

        var roses = userWines.Where(x => x.Wine?.WineType == WineType.Rosé);
        var amountOfRoses = GetAmountOfBottles(roses.ToList());

        var reds = userWines.Where(x => x.Wine?.WineType == WineType.Red);
        var amountOfReds = GetAmountOfBottles(reds.ToList());

        var sparkling = userWines.Where(x => x.Wine?.WineType == WineType.Sparkling);
        var amountOfSparkling = GetAmountOfBottles(sparkling.ToList());

        var amountOfBottlesPerWineTypeData = new[] { amountOfWhites, amountOfRoses, amountOfReds, amountOfSparkling };

        var dict = new Dictionary<WineType, double>();
        dict.Add(WineType.White, amountOfWhites);
        dict.Add(WineType.Rosé, amountOfRoses);
        dict.Add(WineType.Red, amountOfReds);
        dict.Add(WineType.Sparkling, amountOfSparkling);
        var favouriteWineType = GetFavouriteWineType(dict);

        var amountOfBottlesPerWineTypeLabels = new[]
            { nameof(WineType.White), nameof(WineType.Rosé), nameof(WineType.Red), nameof(WineType.Sparkling) };

        var favouriteWine = GetFavouriteWine(userWines);
        var favouriteWineName = $"{favouriteWine.Name} - {favouriteWine.Winery.Name}";

        return new GetDashboardResponse()
        {
            AmountOfBottlesInCellar =
                Convert.ToInt32(amountOfWhites + amountOfRoses + amountOfReds + amountOfSparkling),
            AmountOfBottlesPerWineTypeData = amountOfBottlesPerWineTypeData,
            AmountOfBottlesPerWineTypeLabels = amountOfBottlesPerWineTypeLabels,
            FavouriteWineType = favouriteWineType,
            AmountOfBottlesPerWineType = dict,
            FavouriteWine = favouriteWineName
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

    private Wine GetFavouriteWine(IEnumerable<UserWine> userWines)
    {
        return userWines.Aggregate((agg, next) => next.Amount > agg.Amount ? next : agg).Wine;
    }
}