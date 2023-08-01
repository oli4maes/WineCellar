using WineCellar.Domain.Common;
using WineCellar.Domain.Enums;

namespace WineCellar.Domain.Entities;

public class Wine : BaseAuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public WineType WineType { get; set; }

    public int WineryId { get; set; }
    public Winery Winery { get; set; }

    public int? RegionId { get; set; }
    public Region? Region { get; set; }

    public List<Grape> Grapes { get; set; }
    public List<GrapeWine> GrapeWines { get; set; }
}