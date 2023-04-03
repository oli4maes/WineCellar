﻿using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure.Persistence.Repositories;

public class UserWineRepository : IUserWineRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public UserWineRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<List<UserWine>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<UserWine?> GetById(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public Task<UserWine?> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var userWineModel = await context.UserWines!
            .FirstOrDefaultAsync(x => x.Id == id);

        if (userWineModel == null)
        {
            return false;
        }

        context.UserWines!.Remove(userWineModel);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<List<UserWine>> GetUserWines(string auth0Id)
    {
        ArgumentException.ThrowIfNullOrEmpty(auth0Id);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .Include(x => x.Wine)
            .ThenInclude(w => w.Winery)
            .Include(w => w.Wine.Region)
            .Where(x => x.Auth0Id == auth0Id)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<UserWine?> GetByWineId(int wineId, string auth0Id)
    {
        ArgumentNullException.ThrowIfNull(wineId);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.UserWines!
            .Include(x => x.Wine)
            .ThenInclude(w => w!.Winery)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Wine!.Id == wineId && x.Auth0Id == auth0Id);
    }

    public async Task Update(UserWine userWine)
    {
        ArgumentNullException.ThrowIfNull(userWine);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var userWineModel = await context.UserWines!
            .FirstOrDefaultAsync(x => x.Id == userWine.Id);

        if (userWineModel == null)
        {
            throw new Exception("Couldn't find the user wine to update.");
        }

        userWineModel.Amount = userWine.Amount;
        userWineModel.LastModified = DateTime.UtcNow;
        userWineModel.LastModifiedBy = userWine.LastModifiedBy;

        await context.SaveChangesAsync();
    }

    public async Task<UserWine> Create(UserWine entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await using var context = await _dbContextFactory.CreateDbContextAsync();

        await context.UserWines!.AddAsync(entity);
        await context.SaveChangesAsync();

        return entity;
    }
}