using System.ComponentModel.DataAnnotations;

namespace WineCellar.Application.Grapes.Dto;

public class GrapeDto
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Name is too long (50 characters limit).")]
    public string Name { get; set; } = String.Empty;

    [StringLength(1000, ErrorMessage = "Description is too long (1000 characters limit).")]
    public string? Description { get; set; }
}
