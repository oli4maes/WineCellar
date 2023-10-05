using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Grapes.GetGrapes;

internal sealed class GetGrapesHandler : IRequestHandler<GetGrapesRequest, GetGrapesResponse>
{
    private readonly IQueryFacade _queryFacade;


    public GetGrapesHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetGrapesResponse> Handle(GetGrapesRequest request, CancellationToken cancellationToken)
    {
        var grapes = _queryFacade.Grapes;

        return new GetGrapesResponse()
        {
            Grapes = await grapes.Select(x => new GrapeDto()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                GrapeType = x.GrapeType
            }).ToListAsync(cancellationToken)
        };
    }
}