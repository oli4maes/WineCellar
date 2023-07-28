using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.AddBottleToCellar;

internal sealed class AddBottleToCellarHandler : IRequestHandler<AddBottleToCellarRequest, AddBottleToCellarResponse>
{
    private readonly IBottleRepository _bottleRepository;

    public AddBottleToCellarHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<AddBottleToCellarResponse> Handle(AddBottleToCellarRequest request,
        CancellationToken cancellationToken)
    {
        Bottle bottle = new()
        {
            Auth0Id = request.Auth0Id,
            WineId = request.WineId,
            BottleSize = request.BottleSize,
            Vintage = request.Vintage,
            CreatedBy = request.UserName
        };

        await _bottleRepository.Create(bottle);

        return new AddBottleToCellarResponse()
        {
            Bottle = new AddBottleToCellarResponse.BottleDto()
            {
                Id = bottle.Id,
                BottleSize = bottle.BottleSize,
                Vintage = bottle.Vintage,
                WineId = bottle.WineId
            }
        };
    }
}