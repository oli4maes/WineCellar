using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Wines.GetWineById;

internal sealed class GetWineByIdHandler : IRequestHandler<GetWineByIdRequest, GetWineByIdResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetWineByIdHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetWineByIdResponse> Handle(GetWineByIdRequest request, CancellationToken cancellationToken)
    {
        var isInCellar = false;

        var wine = await _queryFacade.Wines.SingleAsync(x => x.Id == request.Id, cancellationToken);

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
                IsInUserCellar = isInCellar,
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