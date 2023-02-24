namespace WineCellar.Application.Features.Wines.GetWineById;

public sealed class GetWineByIdResponse
{
    public string? ErrorMessage { get; set; }
    public WineDto? Wine { get; set; }
}