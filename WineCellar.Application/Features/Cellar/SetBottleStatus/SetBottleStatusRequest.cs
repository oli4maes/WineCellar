using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.SetBottleStatus;

public sealed record SetBottleStatusRequest(
        int BottleId,
        BottleStatus Status,
        DateTime? ConsumedOn,
        string UserName)
    : IRequest<SetBottleStatusResponse>;