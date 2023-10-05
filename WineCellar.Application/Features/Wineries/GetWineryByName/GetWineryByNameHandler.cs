using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Wineries.GetWineryByName;

internal sealed class GetWineryByNameHandler : IRequestHandler<GetWineryByNameRequest, GetWineryByNameResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetWineryByNameHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetWineryByNameResponse> Handle(GetWineryByNameRequest request,
        CancellationToken cancellationToken)
    {
        var winery = await _queryFacade.Wineries
            .SingleOrDefaultAsync(x => x.Name.ToLower() == request.Name.ToLower(), cancellationToken);

        if (winery is null)
        {
            return new GetWineryByNameResponse();
        }

        return new GetWineryByNameResponse()
        {
            Winery = new WineryDto()
            {
                Id = winery.Id,
                Name = winery.Name,
                CountryName = winery.Country?.Name,
                CountryId = winery.CountryId,
                Description = winery.Description
            }
        };
    }
}