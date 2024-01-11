using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.GetDashboard;

internal sealed class GetDashboardHandler : IRequestHandler<GetDashboardRequest, GetDashboardResponse>
{
    private readonly IBottleRepository _bottleRepository;

    private const int AMOUNT_OF_MONTHS_FOR_LINECHART = 12;

    public GetDashboardHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<GetDashboardResponse> Handle(GetDashboardRequest request,
        CancellationToken cancellationToken)
    {
        var bottles = await _bottleRepository.GetUserBottles(request.Auth0Id);
        var bottlesInCellar = await _bottleRepository.GetUserBottlesInCellar(request.Auth0Id);

        var amountOfWhites = bottlesInCellar.Count(x => x.Wine.WineType == WineType.White);
        var amountOfRoses = bottlesInCellar.Count(x => x.Wine.WineType == WineType.Rosé);
        var amountOfReds = bottlesInCellar.Count(x => x.Wine.WineType == WineType.Red);
        var amountOfSparkling = bottlesInCellar.Count(x => x.Wine.WineType == WineType.Sparkling);

        var amountOfBottlesPerWineTypeData = new[]
        {
            Convert.ToDouble(amountOfWhites),
            Convert.ToDouble(amountOfRoses),
            Convert.ToDouble(amountOfReds),
            Convert.ToDouble(amountOfSparkling)
        };

        var wineTypeDict = new Dictionary<WineType, double>
        {
            { WineType.White, amountOfWhites },
            { WineType.Rosé, amountOfRoses },
            { WineType.Red, amountOfReds },
            { WineType.Sparkling, amountOfSparkling }
        };

        WineType? favouriteWineType = null;
        if (bottles.Any())
        {
            favouriteWineType = GetFavouriteWineType(wineTypeDict);
        }

        var amountOfBottlesPerWineTypeLabels = new[]
            { nameof(WineType.White), nameof(WineType.Rosé), nameof(WineType.Red), nameof(WineType.Sparkling) };

        var favouriteWine = new Wine();
        string favouriteWineName = null;
        if (bottles.Any())
        {
            favouriteWine = GetFavouriteWine(bottles);
            favouriteWineName = $"{favouriteWine.Winery.Name} - {favouriteWine.Name}";
        }

        var groupedByWinery = bottles.GroupBy(x => x.Wine.WineryId);
        var favouriteWineryId = GetFavouriteWinery(groupedByWinery);

        var favouriteWinery = new Winery();
        if (bottles.Any())
        {
            favouriteWinery = bottles.First(x => x.Wine.WineryId == favouriteWineryId).Wine.Winery;
        }

        var favouriteWineryName = favouriteWinery.Name;

        var amountOfBottlesInCellarPerMonth = GetAmountOfBottlesInCellarPerMonth(bottles);

        var winesInCellarLineChart = new GetDashboardResponse.LineChartDto
        {
            Name = "Bottles in cellar",
            Values = amountOfBottlesInCellarPerMonth.Values.ToList(),
            XAxisLabels = amountOfBottlesInCellarPerMonth.Keys.ToList()
        };

        return new GetDashboardResponse
        {
            AmountOfBottlesInCellar = bottlesInCellar.Count,
            AmountOfBottlesPerWineTypeData = amountOfBottlesPerWineTypeData,
            AmountOfBottlesPerWineTypeLabels = amountOfBottlesPerWineTypeLabels,
            FavouriteWineType = favouriteWineType,
            AmountOfBottlesPerWineType = wineTypeDict,
            FavouriteWine = favouriteWineName,
            FavouriteWineId = favouriteWine.Id,
            FavouriteWinery = favouriteWineryName,
            FavouriteWineryId = favouriteWineryId,
            WinesInCellarLineChart = winesInCellarLineChart
        };
    }

    private static WineType GetFavouriteWineType(Dictionary<WineType, double> dict)
    {
        return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }

    private static Wine GetFavouriteWine(List<Bottle> bottles)
    {
        var grouping = bottles.GroupBy(x => x.WineId);

        var dict = new Dictionary<Wine, int>();

        foreach (var group in grouping)
        {
            var amount = group.Count();

            dict.Add(group.First().Wine, amount);
        }

        return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }

    private static int? GetFavouriteWinery(IEnumerable<IGrouping<int, Bottle>> grouping)
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

    private Dictionary<string, double> GetAmountOfBottlesInCellarPerMonth(List<Bottle> bottles)
    {
        var amountOfBottlesPerMonth = new Dictionary<string, double>();
        var startDate = DateTime.Now.AddMonths(1).AddDays(-DateTime.Now.Day + 1);

        for (var i = AMOUNT_OF_MONTHS_FOR_LINECHART - 1; i >= 0; i--)
        {
            var dateRoundedToMonth = startDate.AddMonths(-i);
            var dateOnlyRoundedToMonth = DateOnly.FromDateTime(dateRoundedToMonth);

            var amountOfBottlesForCurrentMonth = bottles.Count(x =>
                DateOnly.FromDateTime(x.AddedOn) < dateOnlyRoundedToMonth
                && (x.ConsumedOn >= dateRoundedToMonth || x.ConsumedOn == null));

            var month = dateRoundedToMonth.AddMonths(-1).ToString("MMM");

            amountOfBottlesPerMonth.Add(month, amountOfBottlesForCurrentMonth);
        }

        return amountOfBottlesPerMonth;
    }
}