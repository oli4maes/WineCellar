using WineCellar.Domain.Common;

namespace WineCellar.Domain.Entities;

public class Country : BaseAuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;

    public List<Region> Regions { get; set; }
}