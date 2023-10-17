using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.GetBottlesByWineId;

public sealed class GetBottlesByWineIdHandler : IRequestHandler<GetBottlesByWineIdRequest, GetBottlesByWineIdResponse>
{
    private readonly IBottleRepository _bottleRepository;


    public GetBottlesByWineIdHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<GetBottlesByWineIdResponse> Handle(GetBottlesByWineIdRequest request,
        CancellationToken cancellationToken)
    {
        var bottles = await _bottleRepository.GetByWineId(request.WineId, request.Auth0Id);

        if (request.Status is not null)
        {
            bottles = bottles.Where(x => x.Status == request.Status).ToList();
        }

        return new GetBottlesByWineIdResponse()
        {
            Bottles = bottles.Select(x => new GetBottlesByWineIdResponse.BottleDto()
            {
                Id = x.Id,
                BottleSize = x.BottleSize,
                Vintage = x.Vintage == null ? "N.V." : x.Vintage.ToString(),
                AddedOn = x.AddedOn,
                Status = x.Status,
                ConsumedOn = x.ConsumedOn,
                LastModified = x.LastModified
            }).ToList()
        };
    }
}