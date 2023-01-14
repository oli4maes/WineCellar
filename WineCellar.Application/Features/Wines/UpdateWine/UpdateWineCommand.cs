namespace WineCellar.Application.Features.Wines.UpdateWine;

public sealed record UpdateWineCommand(WineDto WineDto, string UserName) : IRequest;

public sealed class UpdateWineHandler : IRequestHandler<UpdateWineCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateWineHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateWineCommand request, CancellationToken cancellationToken)
    {
        Wine wineEntity = _mapper.Map<Wine>(request.WineDto);
        wineEntity.LastModifiedBy = request.UserName;

        await _unitOfWork.Wines.Update(wineEntity);
        await _unitOfWork.CompleteAsync();

        return Unit.Value;
    }
}
