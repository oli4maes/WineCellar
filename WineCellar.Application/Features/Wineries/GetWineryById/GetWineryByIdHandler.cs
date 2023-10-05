using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wineries.GetWineryById;

internal sealed class GetWineryByIdHandler : IRequestHandler<GetWineryByIdRequest, GetWineryByIdResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetWineryByIdHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetWineryByIdResponse> Handle(GetWineryByIdRequest request,
        CancellationToken cancellationToken)
    {
        var winery = await _queryFacade.Wineries
            .SingleAsync(x => x.Id == request.Id, cancellationToken);

        var country = new CountryDto();

        if (winery.Country is not null)
        {
            country.Id = winery.Country.Id;
            country.Name = winery.Country.Name;
        }

        return new GetWineryByIdResponse()
        {
            Winery = new WineryDto()
            {
                Id = winery.Id,
                Name = winery.Name,
                Country = country,
                CountryName = winery.Country?.Name,
                CountryId = winery.CountryId,
                Description = winery.Description
            }
        };
    }
}