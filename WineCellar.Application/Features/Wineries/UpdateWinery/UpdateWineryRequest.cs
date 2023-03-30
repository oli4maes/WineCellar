namespace WineCellar.Application.Features.Wineries.UpdateWinery;

public sealed record UpdateWineryRequest(int Id, string Name, string? Description, string UserName, int? CountryId) : IRequest<UpdateWineryResponse>;