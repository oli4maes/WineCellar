namespace WineCellar.Application.Features.Grapes.UpdateGrape;

public sealed record UpdateGrapeCommand(GrapeDto GrapeDto, string UserName) : IRequest;

internal sealed class UpdateGrapeHandler : IRequestHandler<UpdateGrapeCommand>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public UpdateGrapeHandler(IGrapeRepository grapeRepository, IMapper mapper)
    {
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateGrapeCommand request, CancellationToken cancellationToken)
    {
        Grape grapeEntity = _mapper.Map<Grape>(request.GrapeDto);
        grapeEntity.LastModifiedBy = request.UserName;

        await _grapeRepository.Update(grapeEntity);

        return Unit.Value;
    }
}
