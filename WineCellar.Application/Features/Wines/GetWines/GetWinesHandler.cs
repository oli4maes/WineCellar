using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Wines.GetWines;

internal sealed class GetWinesHandler : IRequestHandler<GetWinesRequest, GetWinesResponse>
{
    private readonly IQueryFacade _queryFacade;
    private readonly IMemoryCache _memoryCache;

    public GetWinesHandler(IQueryFacade queryFacade,
        IMemoryCache memoryCache)
    {
        _queryFacade = queryFacade;
        _memoryCache = memoryCache;
    }

    public async ValueTask<GetWinesResponse> Handle(GetWinesRequest request, CancellationToken cancellationToken)
    {
        if (!_memoryCache.TryGetValue("wines", out List<Wine>? wines) || request.ClearCache)
        {
            wines = await _queryFacade.Wines.ToListAsync(cancellationToken);

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                .SetPriority(CacheItemPriority.Normal);

            _memoryCache.Set("wines", wines, cacheEntryOptions);
        }

        var userWines = new List<Bottle>();

        if (request.Auth0Id is not null)
        {
            userWines = await _queryFacade.Bottles.Where(x => x.Auth0Id == request.Auth0Id)
                .ToListAsync(cancellationToken);
        }

        if (request.Query is not null)
        {
            wines = wines?
                .Where(x => x.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase) ||
                            x.Winery.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        return new GetWinesResponse
        {
            Wines = wines.Select(x => new WineDto
            {
                Id = x.Id,
                Name = x.Name,
                WineType = x.WineType,
                RegionId = x.RegionId,
                RegionName = x.Region?.Name,
                WineryName = x.Winery.Name,
                IsInUserCellar = userWines.Any(y => y.WineId == x.Id)
            }).ToList()
        };
    }
}