namespace WineCellar.Application.Features.Wineries.CreateWinery;

public sealed record CreateWineryCommand(WineryDto WineryDto, string UserName) : IRequest<WineryDto>;

public sealed class CreateWineryHandler : IRequestHandler<CreateWineryCommand, WineryDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateWineryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<WineryDto> Handle(CreateWineryCommand request, CancellationToken cancellationToken)
    {
        Winery entity = new()
        {
            Name = request.WineryDto.Name,
            Description = request.WineryDto.Description,
            CreatedBy = request.UserName
        };

        await _unitOfWork.Wineries.Create(entity);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<WineryDto>(entity);
    }
}
