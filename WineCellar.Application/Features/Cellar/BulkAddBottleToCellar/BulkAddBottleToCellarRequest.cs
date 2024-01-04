using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.BulkAddBottleToCellar;

public sealed record BulkAddBottleToCellarRequest(
    int WineId,
    BottleSize BottleSize,
    int Amount,
    DateTime? AddedOn,
    string UserName,
    string Auth0Id,
    double PricePerBottle,
    int? Vintage = null) : IRequest<BulkAddBottleToCellarResponse>;