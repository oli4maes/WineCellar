namespace WineCellar.Application.Grapes.Commands.UpdateGrape;

public sealed record UpdateGrapeCommand(GrapeDto GrapeDto) : IRequest;

public sealed class UpdateGrapeHandler : IRequestHandler<UpdateGrapeCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateGrapeHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateGrapeCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.Grapes.Update(_mapper.Map<Grape>(request.GrapeDto));
        await _unitOfWork.CompleteAsync();

        return Unit.Value;
    }
}
