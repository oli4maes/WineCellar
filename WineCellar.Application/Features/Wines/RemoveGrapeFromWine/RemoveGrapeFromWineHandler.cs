namespace WineCellar.Application.Features.Wines.RemoveGrapeFromWine;

public class RemoveGrapeFromWineHandler : IRequestHandler<RemoveGrapeFromWineRequest, RemoveGrapeFromWineResponse>
{
    private readonly IWineRepository _wineRepository;

    public RemoveGrapeFromWineHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }
    
    public async ValueTask<RemoveGrapeFromWineResponse> Handle(RemoveGrapeFromWineRequest request, CancellationToken cancellationToken)
    {
        await _wineRepository.RemoveGrapeFromWine(request.GrapeId, request.WineId);

        return new RemoveGrapeFromWineResponse();
    }
}