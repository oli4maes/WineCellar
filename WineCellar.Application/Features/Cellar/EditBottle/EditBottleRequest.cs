using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.EditBottle;

public sealed record EditBottleRequest(
        int BottleId,
        BottleSize BottleSize,
        DateTime AddedOn,
        string UserName,
        int? Vintage)
    : IRequest<EditBottleResponse>;