namespace WineCellar.Application.Features.Grapes.GetGrapeByName;

public sealed record GetGrapeByNameRequest(string Name) : IRequest<GetGrapeByNameResponse>;