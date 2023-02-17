using WineCellar.Application.Features.Wines.GetWines;

namespace WineCellar.Application.Features.Wines.GetWineById;

internal sealed class GetWineByIdHandler : IRequestHandler<GetWineByIdRequest, GetWineByIdResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IMapper _mapper;

    public GetWineByIdHandler(IWineRepository wineRepository, IMapper mapper)
    {
        _wineRepository = wineRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetWineByIdResponse> Handle(GetWineByIdRequest request, CancellationToken cancellationToken)
    {
        var wine = await _wineRepository.GetById(request.Id);

        return new GetWineByIdResponse()
        {
            Wine = _mapper.Map<WineDto>(wine)
        };
    }
}