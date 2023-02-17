namespace WineCellar.Application.Features.Wineries.DeleteWinery;



internal sealed class DeleteWineryHandler : IRequestHandler<DeleteWineryRequest, DeleteWineryResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public DeleteWineryHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<DeleteWineryResponse> Handle(DeleteWineryRequest request, CancellationToken cancellationToken)
    {
        bool success = await _wineryRepository.Delete(request.Id);

        return new DeleteWineryResponse()
        {
            SuccessfulDelete = success
        };
    }
}
