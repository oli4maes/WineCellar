using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wineries.GetWineryDetail;

public sealed class GetWineryDetailHandler : IRequestHandler<GetWineryDetailRequest, GetWineryDetailResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetWineryDetailHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetWineryDetailResponse> Handle(GetWineryDetailRequest request,
        CancellationToken cancellationToken)
    {
        var winery = await _queryFacade.Wineries.SingleAsync(x => x.Id == request.WineryId, cancellationToken);

        var wines = _queryFacade.Wines.Where(x => x.WineryId == request.WineryId);

        var bottlesInCellar = await _queryFacade.Bottles.Where(x => x.Auth0Id == request.Auth0Id)
            .ToListAsync(cancellationToken);

        var wineryWines = new List<WineDto>();

        foreach (var wine in wines)
        {
            bool isWineInUserCellar = bottlesInCellar.Any(x => x.WineId == wine.Id);

            wineryWines.Add(new WineDto()
            {
                IsInUserCellar = isWineInUserCellar,
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType,
                RegionName = wine.Region?.Name
            });
        }

        return new GetWineryDetailResponse()
        {
            Winery = Map(winery),
            Wines = wineryWines
        };
    }

    private WineryDto Map(Winery winery)
    {
        return new WineryDto()
        {
            Id = winery.Id,
            Name = winery.Name,
            CountryId = winery.CountryId,
            CountryName = winery.Country?.Name,
            Description = winery.Description
        };
    }
}