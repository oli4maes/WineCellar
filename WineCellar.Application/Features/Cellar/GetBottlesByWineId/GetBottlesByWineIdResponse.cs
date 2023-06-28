namespace WineCellar.Application.Features.Cellar.GetBottlesByWineId;

public sealed class GetBottlesByWineIdResponse
{
    public string? ErrorMessage { get; set; }
    public List<BottleDto>? Bottles { get; set; }
}