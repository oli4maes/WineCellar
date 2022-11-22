namespace WineCellar.Application.Wineries.Commands.UpdateWinery;

public sealed record UpdateWineryCommand(WineryDto WineryDto, string UserName) : IRequest;

public sealed class UpdateWineryHandler : IRequestHandler<UpdateWineryCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateWineryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateWineryCommand request, CancellationToken cancellationToken)
    {
        Winery wineryEntity = _mapper.Map<Winery>(request.WineryDto);
        wineryEntity.LastModifiedBy = request.UserName;

        await _unitOfWork.Wineries.Update(wineryEntity);
        await _unitOfWork.CompleteAsync();

        return Unit.Value;
    }
}
