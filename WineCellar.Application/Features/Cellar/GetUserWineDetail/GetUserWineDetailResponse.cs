namespace WineCellar.Application.Features.Cellar.GetUserWineDetail;

public sealed class GetUserWineDetailResponse
{
    public string? ErrorMessage { get; set; }
    public UserWineDto? UserWine { get; set; }
}