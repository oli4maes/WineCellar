namespace WineCellar.Infrastructure.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;

    public IGrapeRepository Grapes { get; set; }
    public IWineryRepository Wineries { get; set; }
    public IWineRepository Wines { get; set; }
    public IUserWineRepository UserWines { get; set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;

        Grapes = new GrapeRepository(context);
        Wineries = new WineryRepository(context);
        Wines = new WineRepository(context);
        UserWines = new UserWineRepository(context);
    }      

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}

