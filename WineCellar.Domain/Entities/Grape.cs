using WineCellar.Domain.Common;

namespace WineCellar.Domain.Entities;

public class Grape : BaseAuditableEntity
{
    public string Name { get; set; } = String.Empty;
    public string? Description { get; set; }    
}
