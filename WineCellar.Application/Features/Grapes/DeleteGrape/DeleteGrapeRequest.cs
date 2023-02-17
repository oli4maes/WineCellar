namespace WineCellar.Application.Features.Grapes.DeleteGrape;

public sealed record DeleteGrapeRequest(int Id) : IRequest<DeleteGrapeResponse>;