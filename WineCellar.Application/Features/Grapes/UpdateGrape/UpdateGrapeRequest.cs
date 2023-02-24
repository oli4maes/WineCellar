namespace WineCellar.Application.Features.Grapes.UpdateGrape;

public sealed record UpdateGrapeRequest(int Id, string Name, string? Description, string UserName) : IRequest<UpdateGrapeResponse>;