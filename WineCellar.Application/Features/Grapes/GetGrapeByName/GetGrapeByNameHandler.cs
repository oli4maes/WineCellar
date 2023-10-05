using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Grapes.GetGrapeByName;

internal sealed class GetGrapeByNameHandler : IRequestHandler<GetGrapeByNameRequest, GetGrapeByNameResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetGrapeByNameHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetGrapeByNameResponse> Handle(GetGrapeByNameRequest request,
        CancellationToken cancellationToken)
    {
        var grape = await _queryFacade.Grapes
            .SingleOrDefaultAsync(x =>
                x.Name.Contains(request.Name, StringComparison.CurrentCultureIgnoreCase), cancellationToken);

        if (grape is null)
        {
            return new GetGrapeByNameResponse();
        }

        return new GetGrapeByNameResponse()
        {
            Grape = new GrapeDto()
            {
                Id = grape.Id,
                Name = grape.Name,
                Description = grape.Description,
                GrapeType = grape.GrapeType
            }
        };
    }
}