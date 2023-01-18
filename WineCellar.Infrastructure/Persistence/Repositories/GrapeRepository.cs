namespace WineCellar.Infrastructure.Persistence.Repositories;

public class GrapeRepository : GenericRepository<Grape>, IGrapeRepository
{
    public GrapeRepository(ApplicationDbContext context) : base(context)
    {
    }

    public override async Task<bool> Delete(int id)
    {
        var grapeModel = await DbSet.FirstOrDefaultAsync(x => x.Id == id);

        if (grapeModel == null)
        {
            return false;
        }

        DbSet.Remove(grapeModel);

        return true;
    }

    public override async Task Update(Grape grape)
    {
        var grapeModel = await DbSet.FirstOrDefaultAsync(x => x.Id == grape.Id);

        if (grapeModel == null)
        {
            throw new Exception("Couldn't find the grape to update.");
        }

        grapeModel.Name = grape.Name;
        grapeModel.Description = grape.Description;
        grapeModel.LastModified = DateTime.UtcNow;
        grapeModel.LastModifiedBy = grape.LastModifiedBy;
    }

    public override async Task<Grape?> GetByName(string name)
    {
        return await DbSet.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
    }
}