using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Wineries.GetWineries;

internal sealed class GetWineriesHandler : IRequestHandler<GetWineriesRequest, GetWineriesResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetWineriesHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetWineriesResponse> Handle(GetWineriesRequest request, CancellationToken cancellationToken)
    {
        var wineries = _queryFacade.Wineries;

        return new GetWineriesResponse()
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