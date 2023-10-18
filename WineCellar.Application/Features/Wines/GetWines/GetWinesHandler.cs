using Microsoft.Extensions.Caching.Memory;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wines.GetWines;

internal sealed class GetWinesHandler : IRequestHandler<GetWinesRequest, GetWinesResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IBottleRepository _bottleRepository;
    private readonly IMemoryCache _memoryCache;

    public GetWinesHandler(IWineRepository wineRepository,
        IBottleRepository bottleRepository,
        IMemoryCache memoryCache)
    {
        _wineRepository = wineRepository;
        _bottleRepository = bottleRepository;
        _memoryCache = memoryCache;
    }

    public async ValueTask<GetWinesResponse> Handle(GetWinesRequest request, CancellationToken cancellationToken)
    {
        if (!_memoryCache.TryGetValue("wines", out List<Wine>? wines) || request.ClearCache)
        {
            wines = await _wineRepository.All();

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                .SetPriority(CacheItemPriority.Normal);

            _memoryCache.Set("wines", wines, cacheEntryOptions);
        }

        var userWines = new List<Bottle>();

        if (request.Auth0Id is not null)
        {
            userWines = await _bottleRepository.GetUserBottles(request.Auth0Id);
        }

        if (request.Query is not null)
        {
            wines = wines?
                .Where(x => x.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase) ||
                            x.Winery.Name.Contains(request.Query, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        if (request.WineryId is not null)
        {
            wines = wines?.Where(x => x.WineryId == request.WineryId).ToList();
        }

        return new GetWinesResponse
        {
            Wines = wines!.Select(x => new WineDto
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