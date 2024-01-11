using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.EditBottle;

internal sealed class EditBottleHandler : IRequestHandler<EditBottleRequest, EditBottleResponse>
{
    private readonly IBottleRepository _bottleRepository;

    public EditBottleHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<EditBottleResponse> Handle(EditBottleRequest request, CancellationToken cancellationToken)
    {
        var bottle = new Bottle
        {
            Id = request.BottleId,
            BottleSize = request.BottleSize,
            Vintage = request.Vintage,
            Price = request.Price,
            AddedOn = request.AddedOn,
            LastModifiedBy = request.UserName
        };

        await _bottleRepository.Update(bottle);

        return new EditBottleResponse();
    }
}