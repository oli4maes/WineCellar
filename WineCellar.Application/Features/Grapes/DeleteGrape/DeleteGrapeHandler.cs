namespace WineCellar.Application.Features.Grapes.DeleteGrape;

internal sealed class DeleteGrapeHandler : IRequestHandler<DeleteGrapeRequest, DeleteGrapeResponse>
{
    private readonly IGrapeRepository _grapeRepository;

    public DeleteGrapeHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<DeleteGrapeResponse> Handle(DeleteGrapeRequest request, CancellationToken cancellationToken)
    {
        bool success = await _grapeRepository.Delete(request.Id);

        return new DeleteGrapeResponse()
        {
            SuccessfulDelete = success
        };
    }
}

