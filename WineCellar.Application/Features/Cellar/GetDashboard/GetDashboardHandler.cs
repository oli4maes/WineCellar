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
        var amountOfWhites = userWines.Count(x => x.Wine.WineType == WineType.White);
        var amountOfRoses = userWines.Count(x => x.Wine.WineType == WineType.Rose);
        var amountOfReds = userWines.Count(x => x.Wine.WineType == WineType.Red);
        var amountOfSparkling = userWines.Count(x => x.Wine.WineType == WineType.Sparkling);

        return new GetDashboardResponse()
        {
            AmountOfBottlesInCellar = userWines.Count(),
            AmountOfBottlesPerWineTypeData = new[]
            {
                Convert.ToDouble(amountOfWhites),
                Convert.ToDouble(amountOfRoses),
                Convert.ToDouble(amountOfReds),
                Convert.ToDouble(amountOfSparkling)
            },
            AmountOfBottlesPerWineTypeLabels = new[]
            {
                WineType.White.ToString(),
                WineType.Rose.ToString(),
                WineType.Red.ToString(),
                WineType.Sparkling.ToString()
            }
        };
    }
}