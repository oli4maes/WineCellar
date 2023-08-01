using WineCellar.Domain.Enums;

namespace WineCellar.Application.Dtos;

public class GrapeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public GrapeType GrapeType { get; set; }
}