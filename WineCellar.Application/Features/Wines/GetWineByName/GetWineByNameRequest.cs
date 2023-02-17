namespace WineCellar.Application.Features.Wines.GetWineByName;

public sealed record GetWineByNameRequest(string Name) : IRequest<GetWineByNameResponse>;