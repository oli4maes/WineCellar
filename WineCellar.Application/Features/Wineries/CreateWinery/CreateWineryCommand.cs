namespace WineCellar.Application.Features.Wineries.CreateWinery;

public sealed record CreateWineryCommand(WineryDto WineryDto, string UserName) : IRequest<WineryDto>;

internal sealed class CreateWineryHandler : IRequestHandler<CreateWineryCommand, WineryDto>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMapper _mapper;

    public CreateWineryHandler(IWineryRepository wineryRepository, IMapper mapper)
    {
        _wineryRepository = wineryRepository;
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

        await _wineryRepository.Create(entity);

        return _mapper.Map<WineryDto>(entity);
    }
}
