namespace WineCellar.Application.Features.Grapes.GetGrapeByName;

public sealed record GetGrapeByNameQuery(string Name) : IRequest<GrapeDto?>;

public sealed class GetGrapeByNameHandler : IRequestHandler<GetGrapeByNameQuery, GrapeDto?>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetGrapeByNameHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<GrapeDto?> Handle(GetGrapeByNameQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<GrapeDto>(await _unitOfWork.Grapes.GetByName(request.Name));
    }
}
