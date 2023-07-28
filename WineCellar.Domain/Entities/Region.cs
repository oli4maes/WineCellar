using WineCellar.Domain.Common;

namespace WineCellar.Domain.Entities;

public class Region : BaseAuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string? Description { get; set; }
    public bool IsArchived { get; set; } = true;

    public int CountryId { get; set; }
    public Country Country { get; set; }
}