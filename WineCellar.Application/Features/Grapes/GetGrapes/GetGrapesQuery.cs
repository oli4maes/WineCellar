namespace WineCellar.Application.Features.Grapes.GetGrapes;

public sealed record GetGrapesQuery : IRequest<List<GrapeDto>>;

public sealed class GetGrapesHandler : IRequestHandler<GetGrapesQuery, List<GrapeDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetGrapesHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<List<GrapeDto>> Handle(GetGrapesQuery request, CancellationToken cancellationToken)
    {
        var grapes = await _unitOfWork.Grapes.All();

        return _mapper.Map<List<GrapeDto>>(grapes);
    }
}