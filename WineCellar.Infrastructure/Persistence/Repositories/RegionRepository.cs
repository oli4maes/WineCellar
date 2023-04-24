using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure.Persistence.Repositories;

public class RegionRepository : IRegionRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public RegionRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<List<Region>> GetByCountry(int countryId)
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Regions
            .Where(x => x.CountryId == countryId)
            .OrderBy(x => x.Name)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<Region>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Regions
            .OrderBy(x => x.Name)
            .Include(x => x.Country)
            .AsNoTracking()
            .ToListAsync();
    }

    public Task<Region?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Region?> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Region entity)
    {
        throw new NotImplementedException();
    }

    public Task<Region> Create(Region entity)
    {
        throw new NotImplementedException();
    }
}