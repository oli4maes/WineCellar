using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wines.GetWineById;

internal sealed class GetWineByIdHandler : IRequestHandler<GetWineByIdRequest, GetWineByIdResponse>
{
    private readonly IWineRepository _wineRepository;

    public GetWineByIdHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }

    public async ValueTask<GetWineByIdResponse> Handle(GetWineByIdRequest request, CancellationToken cancellationToken)
    {
        var wine = await _wineRepository.GetById(request.Id);

        if (wine is null)
        {
            return new GetWineByIdResponse()
            {
                ErrorMessage = $"Couldn't find the wine with id: {request.Id}"
            };
        }

        var region = new RegionDto();

        if (wine.Region is not null)
        {
            region.Id = wine.Region.Id;
            region.Name = wine.Region.Name;
        }

        return new GetWineByIdResponse()
        {
            Wine = new WineDto()
            {
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType,
                Region = region,
                RegionId = wine.Region?.Id,
                RegionName = wine.Region?.Name,
                WineryName = wine.Winery.Name,
                Winery = new WineryDto()
                {
                    Id = wine.Winery.Id,
                    Name = wine.Winery.Name,
                    CountryId = wine.Winery.CountryId,
                    CountryName = wine.Winery.Country?.Name,
                    Description = wine.Winery.Description
                },
                Grapes = wine?.Grapes.Select(x => new GrapeDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    GrapeType = x.GrapeType
                }).ToList() ?? new List<GrapeDto>()
            }
        };
    }
}