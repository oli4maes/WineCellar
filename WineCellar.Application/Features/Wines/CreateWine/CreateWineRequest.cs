namespace WineCellar.Application.Features.Wines.CreateWine;

public sealed record CreateWineRequest(WineDto WineDto, string UserName) : IRequest<CreateWineResponse>;