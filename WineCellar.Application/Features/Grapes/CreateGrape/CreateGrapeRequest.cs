using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Grapes.CreateGrape;

public sealed record CreateGrapeRequest(string Name, string? Description, string UserName, GrapeType GrapeType) : IRequest<CreateGrapeResponse>;