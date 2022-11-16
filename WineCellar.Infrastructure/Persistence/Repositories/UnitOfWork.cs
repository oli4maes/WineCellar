namespace WineCellar.Infrastructure.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;

    public IGrapeRepository Grapes { get; set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;

        Grapes = new GrapeRepository(context);
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

