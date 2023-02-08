namespace WineCellar.Application.Features.Grapes.GetGrapes;

public sealed record GetGrapesQuery : IRequest<List<GrapeDto>>;

internal sealed class GetGrapesHandler : IRequestHandler<GetGrapesQuery, List<GrapeDto>>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public GetGrapesHandler(IGrapeRepository grapeRepository, IMapper mapper)
    {
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async ValueTask<List<GrapeDto>> Handle(GetGrapesQuery request, CancellationToken cancellationToken)
    {
        var grapes = await _grapeRepository.All();

        return _mapper.Map<List<GrapeDto>>(grapes);
    }
}