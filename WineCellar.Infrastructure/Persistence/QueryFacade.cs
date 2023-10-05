using WineCellar.Domain.Persistence;

namespace WineCellar.Infrastructure.Persistence;

public class QueryFacade : IQueryFacade
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private readonly ApplicationDbContext _context;

    public QueryFacade(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
        _context = dbContextFactory.CreateDbContext();
    }

    public IQueryable<Bottle> Bottles => _context.Bottles.AsQueryable().AsNoTracking();
    public IQueryable<Country> Countries => _context.Countries.AsQueryable().AsNoTracking();
    public IQueryable<Grape> Grapes => _context.Grapes.AsQueryable().AsNoTracking();
    public IQueryable<Region> Regions => _context.Regions.AsQueryable().AsNoTracking();
    public IQueryable<Wine> Wines => _context.Wines.AsQueryable().AsNoTracking();
    public IQueryable<Winery> Wineries => _context.Wineries.AsQueryable().AsNoTracking();
}