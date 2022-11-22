namespace WineCellar.Application.Wineries.Queries.GetWineryByName;

public sealed record GetWineryByNameQuery(string Name) : IRequest<WineryDto?>;

public sealed class GetWineryByNameHandler : IRequestHandler<GetWineryByNameQuery, WineryDto?>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GetWineryByNameHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<WineryDto?> Handle(GetWineryByNameQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<WineryDto>(await _unitOfWork.Wineries.GetByName(request.Name));
    }
}
