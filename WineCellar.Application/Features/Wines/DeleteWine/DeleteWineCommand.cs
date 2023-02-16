namespace WineCellar.Application.Features.Wines.DeleteWine;

public sealed record DeleteWineCommand(int Id) : IRequest<bool>;

internal sealed class DeleteWineHandler : IRequestHandler<DeleteWineCommand, bool>
{
    private readonly IWineRepository _wineRepository;

    public DeleteWineHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }

    public async ValueTask<bool> Handle(DeleteWineCommand request, CancellationToken cancellationToken)
    {
        bool succes = await _wineRepository.Delete(request.Id);

        return succes;
    }
}

