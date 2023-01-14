namespace WineCellar.Application.Features.Wines.GetWines;

public sealed record GetWinesQuery : IRequest<List<WineDto>>;

public sealed class GetWinesHandler : IRequestHandler<GetWinesQuery, List<WineDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetWinesHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<WineDto>> Handle(GetWinesQuery request, CancellationToken cancellationToken)
    {
        var wines = await _unitOfWork.Wines.All();

        return _mapper.Map<List<WineDto>>(wines);
    }
}
