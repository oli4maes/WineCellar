using WineCellar.Application.Grapes.Queries.GetGrapes;

namespace WineCellar.Application.Grapes.Handlers;

public class GetGrapesHandler : IRequestHandler<GetGrapesQuery, List<Grape>>
{
    private readonly IApplicationDbContext _context;

    public GetGrapesHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public Task<List<Grape>> Handle(GetGrapesQuery request, CancellationToken cancellationToken)
    {
        return _context.Grapes.ToListAsync();
    }
}
