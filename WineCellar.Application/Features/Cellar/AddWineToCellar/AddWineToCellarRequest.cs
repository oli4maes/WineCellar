namespace WineCellar.Application.Features.Cellar.AddWineToCellar;

public sealed record AddWineToCellarRequest(int WineId, int Amount, string UserName, string Auth0Id) : IRequest<AddWineToCellarResponse>;