namespace WineCellar.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Grape> Grapes => Set<Grape>();
    public DbSet<Winery> Wineries => Set<Winery>();
    public DbSet<Wine> Wines => Set<Wine>();

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
