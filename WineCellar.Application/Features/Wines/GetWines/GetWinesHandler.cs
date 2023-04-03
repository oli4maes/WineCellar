using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wines.GetWines;

internal sealed class GetWinesHandler : IRequestHandler<GetWinesRequest, GetWinesResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IUserWineRepository _userWineRepository;

    public GetWinesHandler(IWineRepository wineRepository, IUserWineRepository userWineRepository)
    {
        _wineRepository = wineRepository;
        _userWineRepository = userWineRepository;
    }

    public async ValueTask<GetWinesResponse> Handle(GetWinesRequest request, CancellationToken cancellationToken)
    {
        List<Wine> wines;
        var userWines = new List<UserWine>();

        if (request.IsSpotlit)
        {
            wines = await _wineRepository.GetAllSpotlit();
        }
        else
        {
            wines = await _wineRepository.All();
        }

        if (request.Auth0Id is not null)
        {
            userWines = await _userWineRepository.GetUserWines(request.Auth0Id);
        }

        return new GetWinesResponse()
        {
            Wines = wines.Select(x => new WineDto()
            {
                Id = x.Id,
                Name = x.Name,
                WineType = x.WineType,
                IsSpotlit = x.IsSpotlit,
                RegionId = x.RegionId,
                RegionName = x.Region?.Name,
                WineryName = x.Winery.Name,
                IsInUserCellar = userWines.Any(y => y.WineId == x.Id)
            }).ToList()
        };
    }
}