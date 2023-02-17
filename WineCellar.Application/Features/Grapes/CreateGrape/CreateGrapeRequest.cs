namespace WineCellar.Application.Features.Grapes.CreateGrape;

public sealed record CreateGrapeRequest(GrapeDto GrapeDto, string UserName) : IRequest<CreateGrapeResponse>;