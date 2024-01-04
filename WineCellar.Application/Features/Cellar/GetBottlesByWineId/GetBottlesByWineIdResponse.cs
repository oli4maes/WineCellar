using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.GetBottlesByWineId;

public sealed class GetBottlesByWineIdResponse
{
    public string? ErrorMessage { get; set; }
    public List<BottleDto>? Bottles { get; set; }

    public sealed class BottleDto
    {
        public int Id { get; set; }
        public BottleSize BottleSize { get; set; }
        public string? Vintage { get; set; } = string.Empty;
        public DateTime? AddedOn { get; set; }
        public BottleStatus Status { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? ConsumedOn { get; set; }
        public double Price { get; set; } = 0d;
    }
}