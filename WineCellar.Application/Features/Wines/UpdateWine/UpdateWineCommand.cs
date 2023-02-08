namespace WineCellar.Application.Features.Wines.UpdateWine;

public sealed record UpdateWineCommand(WineDto WineDto, string UserName) : IRequest;

internal sealed class UpdateWineHandler : IRequestHandler<UpdateWineCommand>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMapper _mapper;

    public UpdateWineHandler(IWineRepository wineRepository, IMapper mapper)
	{
        _wineRepository = wineRepository;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateWineCommand request, CancellationToken cancellationToken)
    {
        Wine wineEntity = _mapper.Map<Wine>(request.WineDto);
        wineEntity.LastModifiedBy = request.UserName;

        await _wineRepository.Update(wineEntity);

        return Unit.Value;
    }
}
