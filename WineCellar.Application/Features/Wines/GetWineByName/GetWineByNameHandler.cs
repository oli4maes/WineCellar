using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wines.GetWineByName;

internal sealed class GetWineByNameHandler : IRequestHandler<GetWineByNameRequest, GetWineByNameResponse>
{
    private readonly IWineRepository _wineRepository;

    public GetWineByNameHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }

    public async ValueTask<GetWineByNameResponse> Handle(GetWineByNameRequest request,
        CancellationToken cancellationToken)
    {
        var wine = await _wineRepository.GetByName(request.Name);

        if (wine is null)
        {
            return new GetWineByNameResponse();
        }
        
        return new GetWineByNameResponse()
        {
            Wine = new WineDto()
            {
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType
            }
        };
    }
}