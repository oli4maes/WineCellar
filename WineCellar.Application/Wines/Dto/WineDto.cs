using System.ComponentModel.DataAnnotations;
using WineCellar.Domain.Enums;

namespace WineCellar.Application.Wines.Dto;

public class WineDto
{
    public int Id { get; set; }

    [Required]
    [StringLength(250, ErrorMessage = "Name is too long (250 characters limit).")]
    public string Name { get; set; } = String.Empty;

    [Required]
    public WineType WineType { get; set; }

    [Required]
    public int WineryId { get; set; }
    public WineryDto Winery { get; set; }

    public List<GrapeDto> Grapes { get; set; }    
}
