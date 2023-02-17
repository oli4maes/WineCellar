namespace WineCellar.Application.Features.Grapes.GetGrapes;

internal sealed class GetGrapesHandler : IRequestHandler<GetGrapesRequest, GetGrapesResponse>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public GetGrapesHandler(IGrapeRepository grapeRepository, IMapper mapper)
    {
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetGrapesResponse> Handle(GetGrapesRequest request, CancellationToken cancellationToken)
    {
        var grapes = await _grapeRepository.All();

        return new GetGrapesResponse()
        {
            Grapes = _mapper.Map<List<GrapeDto>>(grapes)
        };
    }
}