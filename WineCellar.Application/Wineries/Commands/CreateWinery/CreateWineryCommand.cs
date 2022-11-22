namespace WineCellar.Application.Wineries.Commands.CreateWinery;

public sealed record CreateWineryCommand(string Name, string Description, string UserName) : IRequest<WineryDto>;

public sealed class CreateWineryHandler : IRequestHandler<CreateWineryCommand, WineryDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateWineryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<WineryDto> Handle(CreateWineryCommand request, CancellationToken cancellationToken)
    {
        Winery entity = new();
        entity.Name = request.Name;
        entity.Description = request.Description;
        entity.CreatedBy = request.UserName;

        await _unitOfWork.Wineries.Create(entity);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<WineryDto>(entity);
    }
}
