using System.ComponentModel.DataAnnotations;

namespace WineCellar.Domain.Common;

public abstract class BaseAuditableEntity
{
    public DateTime Created { get; set; } = DateTime.UtcNow;

    [MaxLength(250)]
    public string CreatedBy { get; set; } = String.Empty;

    public DateTime? LastModified { get; set; }

    [MaxLength(250)]
    public string? LastModifiedBy { get; set; }
}
