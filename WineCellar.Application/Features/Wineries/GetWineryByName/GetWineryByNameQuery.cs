namespace WineCellar.Application.Features.Wineries.GetWineryByName;

public sealed record GetWineryByNameQuery(string Name) : IRequest<WineryDto?>;

internal sealed class GetWineryByNameHandler : IRequestHandler<GetWineryByNameQuery, WineryDto?>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMapper _mapper;

    public GetWineryByNameHandler(IWineryRepository wineryRepository, IMapper mapper)
    {
        _wineryRepository = wineryRepository;
        _mapper = mapper;
    }

    public async ValueTask<WineryDto?> Handle(GetWineryByNameQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<WineryDto>(await _wineryRepository.GetByName(request.Name));
    }
}
