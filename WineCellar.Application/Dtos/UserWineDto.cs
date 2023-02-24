namespace WineCellar.Application.Dtos;

public class UserWineDto
{
    public int Id { get; set; }
    public int WineId { get; set; }
    public WineDto? Wine { get; set; } = new();
    public int Amount { get; set; }
}