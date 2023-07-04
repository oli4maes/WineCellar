﻿using WineCellar.Domain.Persistence.Repositories;

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

        foreach (var bottle in bottles)
        {
            if (bottle.Auth0Id != request.Auth0Id)
            {
                return new GetBottlesByWineIdResponse()
                {
                    ErrorMessage = "You don't have access to this item."
                };
            }
        }

        return new GetBottlesByWineIdResponse()
        {
            Bottles = bottles.Select(x => new GetBottlesByWineIdResponse.BottleDto()
            {
                BottleSize = x.BottleSize,
                Vintage = x.Vintage,
                AddedOn = x.Created
            }).ToList()
        };
    }
}