namespace WineCellar.Application.Features.Cellar.DeleteBottle;

public sealed record DeleteBottleRequest(int BottleId) : IRequest<DeleteBottleResponse>;