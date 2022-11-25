using WineCellar.Application.Wines.Queries.GetWineById;

namespace WineCellar.Application.Wines.Commands.CreateWine;

public sealed record CreateWineCommand(WineDto WineDto, string UserName) : IRequest<WineDto>;

public sealed class CreateWineHandler : IRequestHandler<CreateWineCommand, WineDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;

    public CreateWineHandler(IUnitOfWork unitOfWork, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task<WineDto> Handle(CreateWineCommand request, CancellationToken cancellationToken)
    {
        Wine entity = new();
        entity.Name = request.WineDto.Name;
        entity.WineType = request.WineDto.WineType;
        entity.WineryId = request.WineDto.WineryId;
        entity.CreatedBy = request.UserName;

        entity.GrapeWines = new();

        foreach (GrapeDto grape in request.WineDto.Grapes)
        {
            entity.GrapeWines.Add(new GrapeWine { GrapesId = grape.Id });
        }

        await _unitOfWork.Wines.Create(entity);
        await _unitOfWork.CompleteAsync();

        WineDto wine = await _mediator.Send(new GetWineByIdQuery(entity.Id));

        return wine;
    }
}
