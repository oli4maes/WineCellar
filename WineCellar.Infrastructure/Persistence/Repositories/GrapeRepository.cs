using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure.Persistence.Repositories;

public class GrapeRepository :  IGrapeRepository
{
    private readonly ApplicationDbContext _context;
    public GrapeRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _context = dbContextFactory.CreateDbContext();
    }

    public async Task<bool> Delete(int id)
    {
        ArgumentNullException.ThrowIfNull(id);
        
        var grapeModel = await _context.Grapes.FirstOrDefaultAsync(x => x.Id == id);

        if (grapeModel == null)
        {
            return false;
        }

        _context.Grapes.Remove(grapeModel);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task Update(Grape grape)
    {
        ArgumentNullException.ThrowIfNull(grape);
        
        var grapeModel = await _context.Grapes.FirstOrDefaultAsync(x => x.Id == grape.Id);

        if (grapeModel == null)
        {
            throw new Exception("Couldn't find the grape to update.");
        }

        grapeModel.Name = grape.Name;
        grapeModel.Description = grape.Description;
        grapeModel.GrapeType = grape.GrapeType;
        grapeModel.LastModified = DateTime.UtcNow;
        grapeModel.LastModifiedBy = grape.LastModifiedBy;

        await _context.SaveChangesAsync();
    }

    public async Task<Grape> Create(Grape entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await _context.Grapes.AddAsync(entity);
        await _context.SaveChangesAsync();
        
        return entity;
    }
}