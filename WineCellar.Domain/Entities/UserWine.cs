using System.ComponentModel.DataAnnotations;
using WineCellar.Domain.Common;

namespace WineCellar.Domain.Entities;

public class UserWine : BaseAuditableEntity
{
    public int WineId { get; set; }
    public Wine Wine { get; set; }

    [MaxLength(250)]
    public string Auth0Id { get; set; } = string.Empty;

    public int Amount { get; set; }
}
