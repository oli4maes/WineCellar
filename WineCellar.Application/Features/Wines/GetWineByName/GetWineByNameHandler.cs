namespace WineCellar.Application.Features.Wines.GetWineByName;

internal sealed class GetWineByNameHandler : IRequestHandler<GetWineByNameRequest, GetWineByNameResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMapper _mapper;

    public GetWineByNameHandler(IWineRepository wineRepository, IMapper mapper)
    {
        _wineRepository = wineRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetWineByNameResponse> Handle(GetWineByNameRequest request,
        CancellationToken cancellationToken)
    {
        return new GetWineByNameResponse()
        {
            Wine = _mapper.Map<WineDto>(await _wineRepository.GetByName(request.Name))
        };
    }
}