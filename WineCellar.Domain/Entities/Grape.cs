using System.ComponentModel.DataAnnotations;
using WineCellar.Domain.Common;

namespace WineCellar.Domain.Entities;

public class Grape : BaseAuditableEntity
{
    [MaxLength(250)]
    public string Name { get; set; } = String.Empty;

    [MaxLength(2000)]
    public string? Description { get; set; }

    public List<Wine> Wines { get; set; }

    public List<GrapeWine> GrapeWines { get; set; }
}
