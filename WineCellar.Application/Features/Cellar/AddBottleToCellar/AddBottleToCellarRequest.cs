using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.AddBottleToCellar;

public sealed record AddBottleToCellarRequest(
        int WineId,
        BottleSize BottleSize,
        string UserName,
        DateTime? AddedOn,
        string Auth0Id,
        double PricePerBottle,
        int? Vintage = null)
    : IRequest<AddBottleToCellarResponse>;