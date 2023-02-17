namespace WineCellar.Application.Features.Wines.GetWineById;

public sealed record GetWineByIdRequest(int Id) : IRequest<GetWineByIdResponse>;