using WineCellar.Application.Features.Wines.GetWines;

namespace WineCellar.Application.Features.Wines.GetWineById;

internal sealed class GetWineByIdHandler : IRequestHandler<GetWineByIdRequest, GetWineByIdResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMapper _mapper;

    public GetWineByIdHandler(IWineRepository wineRepository, IMapper mapper)
    {
        _wineRepository = wineRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetWineByIdResponse> Handle(GetWineByIdRequest request, CancellationToken cancellationToken)
    {
        var wine = await _wineRepository.GetById(request.Id);

        var grapes = wine?.Grapes.Select(x => new GrapeDto()
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description
        }).ToList();

        return new GetWineByIdResponse()
        {
            Wine = new WineDto()
            {
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType,
                WineryId = wine.WineryId,
                Winery = new WineryDto()
                {
                    Id = wine. Winery.Id,
                    Name = wine.Winery.Name,
                    Description = wine.Winery.Description
                },
                Grapes = grapes ?? new List<GrapeDto>() 
            }
        };
    }
}