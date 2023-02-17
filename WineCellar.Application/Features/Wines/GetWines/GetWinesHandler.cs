namespace WineCellar.Application.Features.Wines.GetWines;

internal sealed class GetWinesHandler : IRequestHandler<GetWinesRequest, GetWinesResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMapper _mapper;

    public GetWinesHandler(IWineRepository wineRepository, IMapper mapper)
    {
        _wineRepository = wineRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetWinesResponse> Handle(GetWinesRequest request, CancellationToken cancellationToken)
    {
        var wines = await _wineRepository.All();

        return new GetWinesResponse()
        {
            Wines = _mapper.Map<List<WineDto>>(wines)
        };
    }
}
