using WineCellar.Domain.Common;

namespace WineCellar.Domain.Entities;

public class GrapeWine : BaseAuditableEntity
{
    public int Id { get; set; }
    public int GrapeId { get; set; }
    public Grape Grape { get; set; }
    public int WineId { get; set; }
    public Wine Wine { get; set; }
}
