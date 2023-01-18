namespace WineCellar.Application.Features.UserWines.DeleteUserWine;

public sealed record DeleteUserWineCommand(int Id) : IRequest<bool>;

public sealed class DeleteUserWineHandler : IRequestHandler<DeleteUserWineCommand, bool> 
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteUserWineHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(DeleteUserWineCommand request, CancellationToken cancellationToken)
    {
        bool succes = await _unitOfWork.UserWines.Delete(request.Id);

        await _unitOfWork.CompleteAsync();

        return succes;
    }
} 