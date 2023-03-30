using System.Diagnostics;
using WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

namespace WineCellar.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        Debug.WriteLine($"{ContextId!} context created.");
    }

    public DbSet<Grape> Grapes { get; set; }
    public DbSet<Winery> Wineries { get; set; }
    public DbSet<Wine> Wines { get; set; }
    public DbSet<UserWine> UserWines { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Region> Regions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        CreateGrapeModel(modelBuilder);
        CreateWineModel(modelBuilder);
        CreateWineryModel(modelBuilder);
        CreateUserWineModel(modelBuilder);
        CreateCountryModel(modelBuilder);
        CreateRegionModel(modelBuilder);
    }

    public override void Dispose()
    {
        Debug.WriteLine($"{ContextId} context disposed.");
        base.Dispose();
    }

    public override ValueTask DisposeAsync()
    {
        Debug.WriteLine($"{ContextId} context disposed async.");
        return base.DisposeAsync();
    }

    private void CreateGrapeModel(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GrapeEntityTypeConfiguration());
    }

    private void CreateWineModel(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WineEntityTypeConfiguration());
    }

    private void CreateWineryModel(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WineryEntityTypeConfiguration());
    }

    private void CreateUserWineModel(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserWineEntityTypeConfiguration());
    }

    private void CreateCountryModel(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CountryEntityTypeConfiguration());
    }

    private void CreateRegionModel(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new RegionEntityTypeConfiguration());
    }
}