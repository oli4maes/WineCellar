﻿using System.ComponentModel.DataAnnotations;
using WineCellar.Domain.Common;

namespace WineCellar.Domain.Entities;

public class Winery : BaseAuditableEntity
{
    public string Name { get; set; } = String.Empty;
    public string? Description { get; set; }

    public int? CountryId { get; set; }
    public Country? Country { get; set; }

    public List<Wine> Wines { get; set; }
}