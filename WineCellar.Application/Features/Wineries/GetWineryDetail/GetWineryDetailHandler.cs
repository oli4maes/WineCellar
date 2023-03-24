namespace WineCellar.Application.Features.Wineries.GetWineryDetail;

public sealed class GetWineryDetailHandler : IRequestHandler<GetWineryDetailRequest, GetWineryDetailResponse>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IWineRepository _wineRepository;
    private readonly IUserWineRepository _userWineRepository;

    public GetWineryDetailHandler(
        IWineryRepository wineryRepository,
        IWineRepository wineRepository,
        IUserWineRepository userWineRepository)
    {
        _wineryRepository = wineryRepository;
        _wineRepository = wineRepository;
        _userWineRepository = userWineRepository;
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
        var userWines = await _userWineRepository.GetUserWines(request.Auth0Id);
        var wineryWines = new List<GetWineryDetailResponse.WineDto>();

        foreach (var wine in wines)
        {
            var enumerable = userWines.ToList();
            bool isWineInUserCellar = enumerable.Any(x => x.WineId == wine.Id);

            wineryWines.Add(new GetWineryDetailResponse.WineDto()
            {
                IsInUserCellar = isWineInUserCellar,
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType
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
            Description = winery.Description
        };
    }
}