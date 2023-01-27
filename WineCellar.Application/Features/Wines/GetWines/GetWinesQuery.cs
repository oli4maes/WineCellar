namespace WineCellar.Application.Features.Wines.GetWines;

public sealed record GetWinesQuery : IRequest<List<WineDto>>;

internal sealed class GetWinesHandler : IRequestHandler<GetWinesQuery, List<WineDto>>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMapper _mapper;

    public GetWinesHandler(IWineRepository wineRepository, IMapper mapper)
    {
        _wineRepository = wineRepository;
        _mapper = mapper;
    }

    public async Task<List<WineDto>> Handle(GetWinesQuery request, CancellationToken cancellationToken)
    {
        var wines = await _wineRepository.All();

        return _mapper.Map<List<WineDto>>(wines);
    }
}
