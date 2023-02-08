namespace WineCellar.Application.Features.Wines.GetWineByName;

public sealed record GetWineByNameQuery(string Name) : IRequest<WineDto?>;

public sealed class GetWineByNameHandler : IRequestHandler<GetWineByNameQuery, WineDto?>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetWineByNameHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<WineDto?> Handle(GetWineByNameQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<WineDto>(await _unitOfWork.Wines.GetByName(request.Name));
    }
}

