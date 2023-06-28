using WineCellar.Domain.Enums;

namespace WineCellar.Application.Dtos;

public class BottleDto
{
    public int Id { get; set; }
    public int WineId { get; set; }
    public BottleSize BottleSize { get; set; }
    public int? Vintage { get; set; }
    public WineDto Wine { get; set; } = new();
}