using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Entities;

namespace WineCellar.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Grape> Grapes { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
