namespace WineCellar.Application.Features.Wineries.GetWineryByName;

internal sealed class GetWineryByNameHandler : IRequestHandler<GetWineryByNameRequest, GetWineryByNameResponse>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMapper _mapper;

    public GetWineryByNameHandler(IWineryRepository wineryRepository, IMapper mapper)
    {
        _wineryRepository = wineryRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetWineryByNameResponse> Handle(GetWineryByNameRequest request,
        CancellationToken cancellationToken)
    {
        return new GetWineryByNameResponse()
        {
            Winery = _mapper.Map<WineryDto>(await _wineryRepository.GetByName(request.Name))
        };
    }
}