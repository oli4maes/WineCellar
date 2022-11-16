namespace WineCellar.Application.Grapes.Commands.UpdateGrape;

public record UpdateGrapeCommand(Grape grape) : IRequest;

public class UpdateGrapeHandler : IRequestHandler<UpdateGrapeCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateGrapeHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateGrapeCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.Grapes.Update(request.grape);
        await _unitOfWork.CompleteAsync();

        return Unit.Value;
    }
}
