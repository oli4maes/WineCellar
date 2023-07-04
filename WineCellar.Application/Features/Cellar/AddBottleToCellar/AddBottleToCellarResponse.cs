using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.AddBottleToCellar;

public sealed class AddBottleToCellarResponse
{
    public BottleDto? Bottle { get; set; }

    public sealed class BottleDto
    {
        public int Id { get; set; }
        public int WineId { get; set; }
        public BottleSize BottleSize { get; set; }
        public int? Vintage { get; set; }
        public WineDto Wine { get; set; } = new();
    }
}