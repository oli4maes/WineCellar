using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.SetBottleStatus;

internal sealed class SetBottleStatusHandler : IRequestHandler<SetBottleStatusRequest, SetBottleStatusResponse>
{
    private readonly IBottleRepository _bottleRepository;

    public SetBottleStatusHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }

    public async ValueTask<SetBottleStatusResponse> Handle(SetBottleStatusRequest request,
        CancellationToken cancellationToken)
    {
        await _bottleRepository.SetStatus(
            request.BottleId,
            request.Status,
            request.ConsumedOn ?? DateTime.Today,
            request.UserName);

        return new SetBottleStatusResponse();
    }
}