﻿using WineCellar.Domain.Common;
using WineCellar.Domain.Enums;

namespace WineCellar.Domain.Entities;

public class Bottle : BaseAuditableEntity
{
    public int Id { get; set; }
    public int WineId { get; set; }
    public Wine Wine { get; set; }
    public string Auth0Id { get; set; } = string.Empty;
    public int? Vintage { get; set; }
    public BottleSize BottleSize { get; set; }
    public BottleStatus Status { get; set; }
    public DateTime AddedOn { get; set; }
    public DateTime? ConsumedOn { get; set; }
    public double Price { get; set; }
}