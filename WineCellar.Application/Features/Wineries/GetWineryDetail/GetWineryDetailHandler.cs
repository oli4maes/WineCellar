using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wineries.GetWineryDetail;

public sealed class GetWineryDetailHandler : IRequestHandler<GetWineryDetailRequest, GetWineryDetailResponse>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IWineRepository _wineRepository;
    private readonly IBottleRepository _bottleRepository;

    public GetWineryDetailHandler(
        IWineryRepository wineryRepository,
        IWineRepository wineRepository,
        IBottleRepository bottleRepository)
    {
        _wineryRepository = wineryRepository;
        _wineRepository = wineRepository;
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<GetWineryDetailResponse> Handle(GetWineryDetailRequest request,
        CancellationToken cancellationToken)
    {
        var winery = await _wineryRepository.GetById(request.WineryId);

        if (winery is null)
        {
            return new GetWineryDetailResponse()
            {
                ErrorMessage = $"Couldn't find the winery with id: {request.WineryId}."
            };
        }

        var wines = await _wineRepository.GetByWineryId(request.WineryId);
        var userWines = await _bottleRepository.GetUserBottles(request.Auth0Id);
        var wineryWines = new List<WineDto>();

        foreach (var wine in wines)
        {
            var enumerable = userWines.ToList();
            bool isWineInUserCellar = enumerable.Any(x => x.WineId == wine.Id);

            wineryWines.Add(new WineDto()
            {
                IsInUserCellar = isWineInUserCellar,
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType,
                RegionName = wine.Region?.Name
            });
        }

        return new GetWineryDetailResponse()
        {
            Winery = Map(winery),
            Wines = wineryWines
        };
    }

    private WineryDto Map(Winery winery)
    {
        return new WineryDto()
        {
            Id = winery.Id,
            Name = winery.Name,
            CountryId = winery.CountryId,
            CountryName = winery.Country?.Name,
            Description = winery.Description
        };
    }
}