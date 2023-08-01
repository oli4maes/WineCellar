﻿namespace WineCellar.Application.Dtos;

public class WineryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string? Description { get; set; }

    public int? CountryId { get; set; }
    public string? CountryName { get; set; }
    public CountryDto? Country { get; set; }
}