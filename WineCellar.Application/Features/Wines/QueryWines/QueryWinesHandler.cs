using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wines.QueryWines;

public class QueryWinesHandler : IRequestHandler<QueryWinesRequest, QueryWinesResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IUserWineRepository _userWineRepository;

    public QueryWinesHandler(IWineRepository wineRepository, IUserWineRepository userWineRepository)
    {
        _wineRepository = wineRepository;
        _userWineRepository = userWineRepository;
    }

    public async ValueTask<QueryWinesResponse> Handle(QueryWinesRequest request, CancellationToken cancellationToken)
    {
        var wines = await _wineRepository.All();
        var userWines = await _userWineRepository.GetUserWines(request.Auth0Id);

        var filteredWines = wines
            .Where(x => x.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase) ||
                        x.Winery.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        var responseWines = new List<WineDto>();

        foreach (var wine in filteredWines)
        {
            bool isWineInUserCellar = userWines.Any(x => x.WineId == wine.Id);

            responseWines.Add(new WineDto()
            {
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType,
                IsSpotlit = wine.IsSpotlit,
                RegionId = wine.RegionId,
                RegionName = wine.Region?.Name,
                WineryName = wine.Winery.Name,
                IsInUserCellar = isWineInUserCellar
            });
        }


        return new QueryWinesResponse()
        {
            Wines = responseWines
        };
    }
}