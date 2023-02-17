namespace WineCellar.Application.Features.Wines.DeleteWine;



internal sealed class DeleteWineHandler : IRequestHandler<DeleteWineRequest, DeleteWineResponse>
{
    private readonly IWineRepository _wineRepository;

    public DeleteWineHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }

    public async ValueTask<DeleteWineResponse> Handle(DeleteWineRequest request, CancellationToken cancellationToken)
    {
        bool succes = await _wineRepository.Delete(request.Id);

        return new DeleteWineResponse()
        {
            SuccessfulDelete = succes
        };
    }
}

