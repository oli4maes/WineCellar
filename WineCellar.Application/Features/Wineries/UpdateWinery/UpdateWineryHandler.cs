namespace WineCellar.Application.Features.Wineries.UpdateWinery;

internal sealed class UpdateWineryHandler : IRequestHandler<UpdateWineryRequest>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMapper _mapper;

    public UpdateWineryHandler(IWineryRepository wineryRepository, IMapper mapper)
    {
        _wineryRepository = wineryRepository;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateWineryRequest request, CancellationToken cancellationToken)
    {
        Winery wineryEntity = _mapper.Map<Winery>(request.WineryDto);
        wineryEntity.LastModifiedBy = request.UserName;

        await _wineryRepository.Update(wineryEntity);

        return Unit.Value;
    }
}