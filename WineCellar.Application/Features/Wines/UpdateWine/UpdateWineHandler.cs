namespace WineCellar.Application.Features.Wines.UpdateWine;

internal sealed class UpdateWineHandler : IRequestHandler<UpdateWineRequest, UpdateWineResponse>
{
    private readonly IWineRepository _wineRepository;

    public UpdateWineHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }

    public async ValueTask<UpdateWineResponse> Handle(UpdateWineRequest request, CancellationToken cancellationToken)
    {
        var wine = new Wine()
        {
            Id = request.Id,
            Name = request.Name,
            WineType = request.WineType,
            WineryId = request.WineryId,
            LastModifiedBy = request.UserName
        };

        await _wineRepository.Update(wine);

        return new UpdateWineResponse();
    }
}