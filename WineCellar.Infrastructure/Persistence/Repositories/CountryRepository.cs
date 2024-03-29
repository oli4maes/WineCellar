﻿using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure.Persistence.Repositories;

public class CountryRepository : ICountryRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private readonly ApplicationDbContext _context;

    public CountryRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
        _context = dbContextFactory.CreateDbContext();
    }

    public async Task<List<Country>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Countries
            .OrderBy(x => x.Name)
            .AsNoTracking()
            .ToListAsync();
    }
}