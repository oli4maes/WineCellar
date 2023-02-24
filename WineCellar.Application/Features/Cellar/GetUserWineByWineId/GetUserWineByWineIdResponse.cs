namespace WineCellar.Application.Features.Cellar.GetUserWineByWineId;

public sealed class GetUserWineByWineIdResponse
{
    public string? ErrorMessage { get; set; }
    public UserWineDto? UserWine { get; set; }
}