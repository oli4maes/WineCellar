namespace WineCellar.Application.Features.Wineries.DeleteWinery;

public sealed record DeleteWineryCommand(int Id) : IRequest<bool>;

internal sealed class DeleteWineryHandler : IRequestHandler<DeleteWineryCommand, bool>
{
    private readonly IWineryRepository _wineryRepository;

    public DeleteWineryHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<bool> Handle(DeleteWineryCommand request, CancellationToken cancellationToken)
    {
        bool success = await _wineryRepository.Delete(request.Id);

        return success;
    }
}
