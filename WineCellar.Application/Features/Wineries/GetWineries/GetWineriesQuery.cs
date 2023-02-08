namespace WineCellar.Application.Features.Wineries.GetWineries;

public sealed record GetWineriesQuery : IRequest<List<WineryDto>>;

internal sealed class GetWineriesHandler : IRequestHandler<GetWineriesQuery, List<WineryDto>>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMapper _mapper;

    public GetWineriesHandler(IWineryRepository wineryRepository, IMapper mapper)
    {
        _wineryRepository = wineryRepository;
        _mapper = mapper;
    }

    public async ValueTask<List<WineryDto>> Handle(GetWineriesQuery request, CancellationToken cancellationToken)
    {
        var wineries = await _wineryRepository.All();

        return _mapper.Map<List<WineryDto>>(wineries);
    }
}

