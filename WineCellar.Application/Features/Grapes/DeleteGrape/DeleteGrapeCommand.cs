namespace WineCellar.Application.Features.Grapes.DeleteGrape;

public sealed record DeleteGrapeCommand(int Id) : IRequest<bool>;

internal sealed class DeleteGrapeHandler : IRequestHandler<DeleteGrapeCommand, bool>
{
    private readonly IGrapeRepository _grapeRepository;

    public DeleteGrapeHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<bool> Handle(DeleteGrapeCommand request, CancellationToken cancellationToken)
    {
        bool success = await _grapeRepository.Delete(request.Id);

        return success;
    }
}

