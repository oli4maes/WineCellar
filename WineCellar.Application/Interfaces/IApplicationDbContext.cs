using Microsoft.EntityFrameworkCore;

namespace WineCellar.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Grape> Grapes { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
