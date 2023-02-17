namespace WineCellar.Application.Features.Grapes.UpdateGrape;

public sealed record UpdateGrapeRequest(GrapeDto GrapeDto, string UserName) : IRequest;