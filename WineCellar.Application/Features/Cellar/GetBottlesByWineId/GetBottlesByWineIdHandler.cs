using Microsoft.EntityFrameworkCore;
using WineCellar.Domain.Persistence;

namespace WineCellar.Application.Features.Cellar.GetBottlesByWineId;

public sealed class GetBottlesByWineIdHandler : IRequestHandler<GetBottlesByWineIdRequest, GetBottlesByWineIdResponse>
{
    private readonly IQueryFacade _queryFacade;

    public GetBottlesByWineIdHandler(IQueryFacade queryFacade)
    {
        _queryFacade = queryFacade;
    }

    public async ValueTask<GetBottlesByWineIdResponse> Handle(GetBottlesByWineIdRequest request,
        CancellationToken cancellationToken)
    {
        var bottles = _queryFacade.Bottles
            .Where(x => x.Wine.Id == request.WineId && x.Auth0Id == request.Auth0Id);

        if (request.Status is not null)
        {
            bottles = bottles.Where(x => x.Status == request.Status);
        }

        return new GetBottlesByWineIdResponse()
        {
            Bottles = await bottles.Select(x => new GetBottlesByWineIdResponse.BottleDto()
            {
                Id = x.Id,
                BottleSize = x.BottleSize,
                Vintage = x.Vintage == null ? "N.V." : x.Vintage.ToString(),
                AddedOn = x.Created,
                Status = x.Status,
                LastModified = x.LastModified
            }).ToListAsync(cancellationToken)
        };
    }
}