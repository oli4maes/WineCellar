namespace WineCellar.Application.Features.Grapes.GetGrapeByName;

public sealed record GetGrapeByNameQuery(string Name) : IRequest<GrapeDto?>;

internal sealed class GetGrapeByNameHandler : IRequestHandler<GetGrapeByNameQuery, GrapeDto?>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public GetGrapeByNameHandler(IGrapeRepository grapeRepository, IMapper mapper)
	{
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async Task<GrapeDto?> Handle(GetGrapeByNameQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<GrapeDto>(await _grapeRepository.GetByName(request.Name));
    }
}
