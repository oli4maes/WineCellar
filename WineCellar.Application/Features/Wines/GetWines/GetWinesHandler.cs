namespace WineCellar.Application.Features.Wines.GetWines;

internal sealed class GetWinesHandler : IRequestHandler<GetWinesRequest, GetWinesResponse>
{
    private readonly IWineRepository _wineRepository;

    public GetWinesHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }

    public async ValueTask<GetWinesResponse> Handle(GetWinesRequest request, CancellationToken cancellationToken)
    {
        var wines = await _wineRepository.All();

        return new GetWinesResponse()
        {
            Wines = wines.Select(x => new WineDto()
            {
                Id = x.Id,
                Name = x.Name,
                WineType = x.WineType,
                WineryName = x.Winery.Name
            })
        };
    }
}