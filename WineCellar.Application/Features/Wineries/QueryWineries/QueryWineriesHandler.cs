using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Wineries.QueryWineries;

public sealed class QueryWineriesHandler : IRequestHandler<QueryWineriesRequest, QueryWineriesResponse>
{
    private readonly IQueryFacade _queryFacade;

    public QueryWineriesHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<QueryWineriesResponse> Handle(QueryWineriesRequest request,
        CancellationToken cancellationToken)
    {
        var wineries = _queryFacade.Wineries
            .Where(x => x.Name.Contains(request.Query, StringComparison.CurrentCultureIgnoreCase));

        return new QueryWineriesResponse()
        {
            Wineries = await wineries.Select(x => new WineryDto()
            {
                Id = x.Id,
                Name = x.Name,
                CountryId = x.CountryId,
                CountryName = x.Country.Name,
                Description = x.Description
            }).ToListAsync(cancellationToken)
        };
    }
}