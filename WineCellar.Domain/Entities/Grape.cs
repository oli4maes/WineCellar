using WineCellar.Domain.Common;
using WineCellar.Domain.Enums;

namespace WineCellar.Domain.Entities;

public class Grape : BaseAuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string? Description { get; set; }
    public GrapeType GrapeType { get; set; }
    public List<Wine> Wines { get; set; }
    public List<GrapeWine> GrapeWines { get; set; }
}