using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Wines.GetWineByName;

internal sealed class GetWineByNameHandler : IRequestHandler<GetWineByNameRequest, GetWineByNameResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetWineByNameHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetWineByNameResponse> Handle(GetWineByNameRequest request,
        CancellationToken cancellationToken)
    {
        var wine = await _queryFacade.Wines
            .FirstOrDefaultAsync(x => x.Name.ToLower() == request.Name.ToLower(), cancellationToken);

        if (wine is null)
        {
            return new GetWineByNameResponse();
        }

        return new GetWineByNameResponse()
        {
            Wine = new WineDto()
            {
                Id = wine.Id,
                Name = wine.Name,
                WineType = wine.WineType
            }
        };
    }
}