using WineCellar.Application.Features.Wines.GetWineById;

namespace WineCellar.Application.Features.Wines.CreateWine;

public sealed record CreateWineCommand(WineDto WineDto, string UserName) : IRequest<WineDto?>;

public sealed class CreateWineHandler : IRequestHandler<CreateWineCommand, WineDto?>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;

    public CreateWineHandler(IUnitOfWork unitOfWork, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task<WineDto?> Handle(CreateWineCommand request, CancellationToken cancellationToken)
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

        await _unitOfWork.Wines.Create(entity);
        await _unitOfWork.CompleteAsync();

        WineDto? wine = await _mediator.Send(new GetWineByIdQuery(entity.Id), cancellationToken);

        return wine;
    }
}
