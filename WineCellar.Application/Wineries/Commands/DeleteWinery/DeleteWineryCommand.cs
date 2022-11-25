﻿namespace WineCellar.Application.Wineries.Commands.DeleteWinery;

public sealed record DeleteWineryCommand(int Id) : IRequest<bool>;

public sealed class DeleteWineryHandler : IRequestHandler<DeleteWineryCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteWineryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(DeleteWineryCommand request, CancellationToken cancellationToken)
    {
        bool succes = await _unitOfWork.Wineries.Delete(request.Id);

        await _unitOfWork.CompleteAsync();

        return succes;
    }
}