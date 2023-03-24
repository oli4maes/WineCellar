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

        var amountOfWhites = Convert.ToDouble(userWines.Count(x => x.Wine.WineType == WineType.White));
        var amountOfRoses = Convert.ToDouble(userWines.Count(x => x.Wine.WineType == WineType.Rose));
        var amountOfReds = Convert.ToDouble(userWines.Count(x => x.Wine.WineType == WineType.Red));
        var amountOfSparkling = Convert.ToDouble(userWines.Count(x => x.Wine.WineType == WineType.Sparkling));
        var amountOfBottlesPerWineTypeData = new[] { amountOfWhites, amountOfRoses, amountOfReds, amountOfSparkling };

        var amountOfBottlesPerWineTypeLabels = userWines
            .GroupBy(x => x.Wine.WineType)
            .OrderBy(x => x.Key)
            .Select(y => y.Key.ToString())
            .ToArray();

        return new GetDashboardResponse()
        {
            AmountOfBottlesInCellar = userWines.Count(),
            AmountOfBottlesPerWineTypeData = amountOfBottlesPerWineTypeData,
            AmountOfBottlesPerWineTypeLabels = amountOfBottlesPerWineTypeLabels
        };
    }
}