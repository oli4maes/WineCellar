using WineCellar.Domain.Enums;

namespace WineCellar.Application.Wines.Commands.CreateWine;

public sealed record CreateWineCommand(string Name, WineType WineType, int WineryId, List<GrapeDto> Grapes, string UserName) : IRequest<WineDto>;

public sealed class CreateWineHandler : IRequestHandler<CreateWineCommand, WineDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateWineHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<WineDto> Handle(CreateWineCommand request, CancellationToken cancellationToken)
    {
        Wine entity = new();
        entity.Name = request.Name;
        entity.WineType = request.WineType;
        entity.WineryId = request.WineryId;
        entity.Grapes = _mapper.Map<List<Grape>>(request.Grapes);
        entity.CreatedBy = request.UserName;

        await _unitOfWork.Wines.Create(entity);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<WineDto>(entity);
    }
}
