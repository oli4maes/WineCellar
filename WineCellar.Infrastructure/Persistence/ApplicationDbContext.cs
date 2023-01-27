using System.Diagnostics;

namespace WineCellar.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        Debug.WriteLine($"{ContextId} context created.");
    }

    public DbSet<Grape>? Grapes { get; set; }
    public DbSet<Winery>? Wineries { get; set; }
    public DbSet<Wine>? Wines { get; set; }
    public DbSet<UserWine>? UserWines { get; set; }

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
}