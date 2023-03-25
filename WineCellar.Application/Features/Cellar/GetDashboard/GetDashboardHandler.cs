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

        var amountOfBottlesPerWineTypeLabels = new[]
            { nameof(WineType.White), nameof(WineType.Rosé), nameof(WineType.Red), nameof(WineType.Sparkling) };

        return new GetDashboardResponse()
        {
            AmountOfBottlesInCellar =
                Convert.ToInt32(amountOfWhites + amountOfRoses + amountOfReds + amountOfSparkling),
            AmountOfBottlesPerWineTypeData = amountOfBottlesPerWineTypeData,
            AmountOfBottlesPerWineTypeLabels = amountOfBottlesPerWineTypeLabels
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
}