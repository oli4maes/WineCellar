namespace WineCellar.Application.Features.Grapes.GetGrapeByName;

internal sealed class GetGrapeByNameHandler : IRequestHandler<GetGrapeByNameRequest, GetGrapeByNameResponse>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public GetGrapeByNameHandler(IGrapeRepository grapeRepository, IMapper mapper)
    {
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetGrapeByNameResponse> Handle(GetGrapeByNameRequest request,
        CancellationToken cancellationToken)
    {
        return new GetGrapeByNameResponse()
        {
            Grape = _mapper.Map<GrapeDto>(await _grapeRepository.GetByName(request.Name))
        };
    }
}