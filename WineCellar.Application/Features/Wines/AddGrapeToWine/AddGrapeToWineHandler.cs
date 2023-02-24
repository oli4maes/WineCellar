namespace WineCellar.Application.Features.Wines.AddGrapeToWine;

internal class AddGrapeToWineHandler : IRequestHandler<AddGrapeToWineRequest, AddGrapeToWineResponse>
{
    private readonly IWineRepository _wineRepository;

    public AddGrapeToWineHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }

    public async ValueTask<AddGrapeToWineResponse> Handle(AddGrapeToWineRequest request,
        CancellationToken cancellationToken)
    {
        await _wineRepository.AddGrapeToWine(request.GrapeId, request.WineId);

        return new AddGrapeToWineResponse();
    }
}