using System.ComponentModel.DataAnnotations;
using WineCellar.Domain.Common;
using WineCellar.Domain.Enums;

namespace WineCellar.Domain.Entities;

public class Wine : BaseAuditableEntity
{
    [MaxLength(250)]
    public string Name { get; set; } = String.Empty;    

    public WineType WineType { get; set; }

    public int WineryId { get; set; }
    public Winery Winery { get; set; }

    public List<Grape> Grapes { get; set; }
    public List<GrapeWine> GrapeWines { get; set; }
}
