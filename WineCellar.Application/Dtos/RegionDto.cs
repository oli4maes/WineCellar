﻿namespace WineCellar.Application.Dtos;

public class RegionDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;

    public CountryDto Country { get; set; } = new();

    public override bool Equals(object o)
    {
        var other = o as RegionDto;
        return other?.Name == Name;
    }

    public override int GetHashCode() => Name?.GetHashCode() ?? 0;

    public override string ToString() => Name;
}