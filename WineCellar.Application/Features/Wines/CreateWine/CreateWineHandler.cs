using WineCellar.Application.Features.Wines.GetWineById;

namespace WineCellar.Application.Features.Wines.CreateWine;

internal sealed class CreateWineHandler : IRequestHandler<CreateWineRequest, CreateWineResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMediator _mediator;

    public CreateWineHandler(IWineRepository wineRepository, IMediator mediator)
    {
        _wineRepository = wineRepository;
        _mediator = mediator;
    }

    public async ValueTask<CreateWineResponse> Handle(CreateWineRequest request, CancellationToken cancellationToken)
    {
        Wine entity = new()
        {
            Name = request.WineDto.Name,
            WineType = request.WineDto.WineType,
            WineryId = request.WineDto.WineryId,
            CreatedBy = request.UserName
        };
        

        entity.GrapeWines = new();

        foreach (GrapeDto grape in request.WineDto.Grapes)
        {
            entity.GrapeWines.Add(new GrapeWine { GrapesId = grape.Id });
        }

        await _wineRepository.Create(entity);

        var response = await _mediator.Send(new GetWineByIdRequest(entity.Id), cancellationToken);

        return new CreateWineResponse()
        {
            Wine = response.Wine
        };
    }
}
