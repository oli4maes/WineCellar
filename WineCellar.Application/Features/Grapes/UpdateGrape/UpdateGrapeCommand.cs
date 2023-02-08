namespace WineCellar.Application.Features.Grapes.UpdateGrape;

public sealed record UpdateGrapeCommand(GrapeDto GrapeDto, string UserName) : IRequest;

public sealed class UpdateGrapeHandler : IRequestHandler<UpdateGrapeCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateGrapeHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateGrapeCommand request, CancellationToken cancellationToken)
    {
        Grape grapeEntity = _mapper.Map<Grape>(request.GrapeDto);
        grapeEntity.LastModifiedBy = request.UserName;

        await _unitOfWork.Grapes.Update(grapeEntity);
        await _unitOfWork.CompleteAsync();

        return Unit.Value;
    }
}
