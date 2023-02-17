namespace WineCellar.Application.Features.Cellar.RemoveWineFromCellar;

public sealed record RemoveWineFromCellarRequest(int Id) : IRequest<RemoveWineFromCellarResponse>;