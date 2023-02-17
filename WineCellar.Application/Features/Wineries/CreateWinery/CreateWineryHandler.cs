namespace WineCellar.Application.Features.Wineries.CreateWinery;

internal sealed class CreateWineryHandler : IRequestHandler<CreateWineryRequest, CreateWineryResponse>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMapper _mapper;

    public CreateWineryHandler(IWineryRepository wineryRepository, IMapper mapper)
    {
        _wineryRepository = wineryRepository;
        _mapper = mapper;
    }

    public async ValueTask<CreateWineryResponse> Handle(CreateWineryRequest request, CancellationToken cancellationToken)
    {
        Winery entity = new()
        {
            Name = request.WineryDto.Name,
            Description = request.WineryDto.Description,
            CreatedBy = request.UserName
        };

        await _wineryRepository.Create(entity);

        return new CreateWineryResponse()
        {
            Winery = _mapper.Map<WineryDto>(entity)
        };
    }
}
