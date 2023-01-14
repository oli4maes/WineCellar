namespace WineCellar.Application.Features.Wines.DeleteWine;

public sealed record DeleteWineCommand(int Id) : IRequest<bool>;

public sealed class DeleteWineHandler : IRequestHandler<DeleteWineCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteWineHandler(IUnitOfWork unitOfWork)
	{
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(DeleteWineCommand request, CancellationToken cancellationToken)
    {
        bool succes = await _unitOfWork.Wines.Delete(request.Id);

        await _unitOfWork.CompleteAsync();

        return succes;
    }
}

