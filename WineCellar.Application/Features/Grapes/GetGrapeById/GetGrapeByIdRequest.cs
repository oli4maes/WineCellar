namespace WineCellar.Application.Features.Grapes.GetGrapeById;

public sealed record GetGrapeByIdRequest(int Id) : IRequest<GetGrapeByIdResponse>;