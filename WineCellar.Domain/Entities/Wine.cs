using System.ComponentModel.DataAnnotations;
using WineCellar.Domain.Common;
using WineCellar.Domain.Enums;

namespace WineCellar.Domain.Entities;

public class Wine : BaseAuditableEntity
{
    public string Name { get; set; } = String.Empty;
    public WineType WineType { get; set; }

    public int WineryId { get; set; }
    public Winery Winery { get; set; }

    public int? CountryId { get; set; }
    public Country? Country { get; set; }

    public List<Grape> Grapes { get; set; }
    public List<GrapeWine> GrapeWines { get; set; }
}