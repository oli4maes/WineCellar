namespace WineCellar.Application.Features.Wineries.GetWineries;

internal sealed class GetWineriesHandler : IRequestHandler<GetWineriesRequest, GetWineriesResponse>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMapper _mapper;

    public GetWineriesHandler(IWineryRepository wineryRepository, IMapper mapper)
    {
        _wineryRepository = wineryRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetWineriesResponse> Handle(GetWineriesRequest request, CancellationToken cancellationToken)
    {
        var wineries = await _wineryRepository.All();

        return new GetWineriesResponse()
        {
            Wineries = _mapper.Map<List<WineryDto>>(wineries)
        };
    }
}

