namespace WineCellar.Application.Features.Wineries.QueryWineries;

public sealed class QueryWineriesHandler : IRequestHandler<QueryWineriesRequest, QueryWineriesResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public QueryWineriesHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<QueryWineriesResponse> Handle(QueryWineriesRequest request,
        CancellationToken cancellationToken)
    {
        var wineries = await _wineryRepository.All();
        var filteredWineries = wineries
            .Where(x => x.Name.Contains(request.Query, StringComparison.CurrentCultureIgnoreCase))
            .ToList();

        return new QueryWineriesResponse()
        {
            Wineries = filteredWineries.Select(x => new WineryDto()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToList()
        };
    }
}