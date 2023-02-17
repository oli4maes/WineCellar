namespace WineCellar.Application.Features.Grapes.UpdateGrape;

internal sealed class UpdateGrapeHandler : IRequestHandler<UpdateGrapeRequest>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public UpdateGrapeHandler(IGrapeRepository grapeRepository, IMapper mapper)
    {
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateGrapeRequest request, CancellationToken cancellationToken)
    {
        Grape grapeEntity = _mapper.Map<Grape>(request.GrapeDto);
        grapeEntity.LastModifiedBy = request.UserName;

        await _grapeRepository.Update(grapeEntity);

        return Unit.Value;
    }
}
