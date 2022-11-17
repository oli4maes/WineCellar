namespace WineCellar.Application.Grapes.Commands.DeleteGrape;

public sealed record DeleteGrapeCommand(int id) : IRequest<bool>;

public sealed class DeleteGrapeHandler : IRequestHandler<DeleteGrapeCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteGrapeHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(DeleteGrapeCommand request, CancellationToken cancellationToken)
    {
        bool succes = await _unitOfWork.Grapes.Delete(request.id);

        await _unitOfWork.CompleteAsync();

        return succes;
    }
}

