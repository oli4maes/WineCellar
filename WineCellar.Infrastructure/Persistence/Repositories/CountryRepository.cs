namespace WineCellar.Infrastructure.Persistence.Repositories;

public class CountryRepository : ICountryRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public CountryRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<List<Country>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Countries
            .AsNoTracking()
            .ToListAsync();
    }
}