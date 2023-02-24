namespace WineCellar.Application.Features.Grapes.CreateGrape;

public sealed record CreateGrapeRequest(string Name, string? Description, string UserName) : IRequest<CreateGrapeResponse>;