using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Grapes.GetGrapeById;

internal sealed class GetGrapeByIdHandler : IRequestHandler<GetGrapeByIdRequest, GetGrapeByIdResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetGrapeByIdHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetGrapeByIdResponse> Handle(GetGrapeByIdRequest request,
        CancellationToken cancellationToken)
    {
        var grape = await _queryFacade.Grapes.SingleAsync(x => x.Id == request.Id, cancellationToken);

        return new GetGrapeByIdResponse
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