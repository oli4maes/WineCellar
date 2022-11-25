namespace WineCellar.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Grape> Grapes => Set<Grape>();
    public DbSet<Winery> Wineries => Set<Winery>();
    public DbSet<Wine> Wines => Set<Wine>();
    public DbSet<UserWine> UserWines=> Set<UserWine>();

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Wine>()
            .HasMany(p => p.Grapes)
            .WithMany(p => p.Wines)
            .UsingEntity<GrapeWine>(
                j => j
                    .HasOne(pt => pt.Grape)
                    .WithMany(t => t.GrapeWines)
                    .HasForeignKey(pt => pt.GrapesId),
                j => j
                    .HasOne(pt => pt.Wine)
                    .WithMany(p => p.GrapeWines)
                    .HasForeignKey(pt => pt.WinesId));
    }
}
