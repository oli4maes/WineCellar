using Microsoft.EntityFrameworkCore;
using WineCellar.Application.Common.Interfaces;
using WineCellar.Domain.Entities;

namespace WineCellar.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Grape> Grapes => Set<Grape>();

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
