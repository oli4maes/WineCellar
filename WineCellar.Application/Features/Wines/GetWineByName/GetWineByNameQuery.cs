namespace WineCellar.Application.Features.Wines.GetWineByName;

public sealed record GetWineByNameQuery(string Name) : IRequest<WineDto?>;

internal sealed class GetWineByNameHandler : IRequestHandler<GetWineByNameQuery, WineDto?>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMapper _mapper;

    public GetWineByNameHandler(IWineRepository wineRepository, IMapper mapper)
    {
        _wineRepository = wineRepository;
        _mapper = mapper;
    }

    public async Task<WineDto?> Handle(GetWineByNameQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<WineDto>(await _wineRepository.GetByName(request.Name));
    }
}

