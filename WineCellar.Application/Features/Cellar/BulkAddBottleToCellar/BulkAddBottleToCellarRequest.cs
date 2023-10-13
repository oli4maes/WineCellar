using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.BulkAddBottleToCellar;

public sealed record BulkAddBottleToCellarRequest(
    int WineId,
    BottleSize BottleSize,
    int Amount,
    DateTime InCellarSince,
    string UserName,
    string Auth0Id,
    int? Vintage = null) : IRequest<BulkAddBottleToCellarResponse>;