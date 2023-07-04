using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.GetBottlesByWineId;

public sealed class GetBottlesByWineIdResponse
{
    public string? ErrorMessage { get; set; }
    public List<BottleDto>? Bottles { get; set; }

    public sealed class BottleDto
    {
        public BottleSize BottleSize { get; set; }
        public int? Vintage { get; set; }
        public DateTime AddedOn { get; set; }
    }
}