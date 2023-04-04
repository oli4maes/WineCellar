using Microsoft.Extensions.Caching.Memory;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wines.GetWines;

internal sealed class GetWinesHandler : IRequestHandler<GetWinesRequest, GetWinesResponse>
{
    private readonly IWineRepository _wineRepository;
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMemoryCache _memoryCache;

    public GetWinesHandler(IWineRepository wineRepository,
        IUserWineRepository userWineRepository,
        IMemoryCache memoryCache)
    {
        _wineRepository = wineRepository;
        _userWineRepository = userWineRepository;
        _memoryCache = memoryCache;
    }

    public async ValueTask<GetWinesResponse> Handle(GetWinesRequest request, CancellationToken cancellationToken)
    {
        if (!_memoryCache.TryGetValue("wines", out List<Wine>? wines))
        {
            wines = await _wineRepository.All();

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                .SetPriority(CacheItemPriority.Normal);

            _memoryCache.Set("wines", wines, cacheEntryOptions);
        }

        var userWines = new List<UserWine>();

        if (request.Auth0Id is not null)
        {
            userWines = await _userWineRepository.GetUserWines(request.Auth0Id);
        }

        if (request.IsSpotlit)
        {
            wines = wines?.Where(x => x.IsSpotlit).ToList();
        }

        return new GetWinesResponse()
        {
            Wines = wines.Select(x => new WineDto()
            {
                Id = x.Id,
                Name = x.Name,
                WineType = x.WineType,
                IsSpotlit = x.IsSpotlit,
                RegionId = x.RegionId,
                RegionName = x.Region?.Name,
                WineryName = x.Winery.Name,
                IsInUserCellar = userWines.Any(y => y.WineId == x.Id)
            }).ToList()
        };
    }
}