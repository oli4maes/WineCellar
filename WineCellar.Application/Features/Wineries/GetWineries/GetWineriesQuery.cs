namespace WineCellar.Application.Features.Wineries.GetWineries;

public sealed record GetWineriesQuery : IRequest<List<WineryDto>>;

public sealed class GetWineriesHandler : IRequestHandler<GetWineriesQuery, List<WineryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetWineriesHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<WineryDto>> Handle(GetWineriesQuery request, CancellationToken cancellationToken)
    {
        var wineries = await _unitOfWork.Wineries.All();

        return _mapper.Map<List<WineryDto>>(wineries);
    }
}

