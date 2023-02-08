namespace WineCellar.Infrastructure.Persistence.Repositories;

public class GrapeRepository :  IGrapeRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public GrapeRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);
        
        await using var context = await _dbContextFactory.CreateDbContextAsync();
        
        var grapeModel = await context.Grapes.FirstOrDefaultAsync(x => x.Id == id);

        if (grapeModel == null)
        {
            return false;
        }

        context.Grapes.Remove(grapeModel);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task Update(Grape grape)
    {
        ArgumentNullException.ThrowIfNull(grape);
        
        await using var context = await _dbContextFactory.CreateDbContextAsync();
        
        var grapeModel = await context.Grapes.FirstOrDefaultAsync(x => x.Id == grape.Id);

        if (grapeModel == null)
        {
            throw new Exception("Couldn't find the grape to update.");
        }

        grapeModel.Name = grape.Name;
        grapeModel.Description = grape.Description;
        grapeModel.LastModified = DateTime.UtcNow;
        grapeModel.LastModifiedBy = grape.LastModifiedBy;

        await context.SaveChangesAsync();
    }

    public async Task<Grape> Create(Grape entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        await context.Grapes.AddAsync(entity);
        await context.SaveChangesAsync();
        
        return entity;
    }

    public async Task<IEnumerable<Grape>> All()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Grapes.AsNoTracking().ToListAsync();
    }

    public async Task<Grape?> GetById(int id)
    {
        ArgumentNullException.ThrowIfNull(id);
        
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        return await context.Grapes.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Grape?> GetByName(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        
        await using var context = await _dbContextFactory.CreateDbContextAsync();
        
        return await context.Grapes.AsNoTracking().FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
    }
}