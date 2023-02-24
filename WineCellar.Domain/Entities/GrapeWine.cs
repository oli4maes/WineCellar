namespace WineCellar.Domain.Entities;

public class GrapeWine
{
    public int GrapeId { get; set; }
    public Grape Grape { get; set; } = new();
    public int WineId { get; set; }
    public Wine Wine { get; set; } = new();
}
