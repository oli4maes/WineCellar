using WineCellar.Application.Features.Wines.GetWineById;
using WineCellar.Application.Features.Wines.GetWineByName;
using WineCellar.Domain.Persistence.Repositories;

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
        var entity = new Wine()
        {
            Name = request.Name,
            WineType = request.WineType,
            WineryId = request.WineryId,
            RegionId = request.RegionId,
            CreatedBy = request.UserName
        };

        await _wineRepository.Create(entity);

        var response = await _mediator.Send(new GetWineByIdRequest(entity.Id), cancellationToken);

        return new CreateWineResponse()
        {
            Wine = response.Wine
        };
    }
}