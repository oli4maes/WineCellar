using System.ComponentModel.DataAnnotations;

namespace WineCellar.Application.Wineries.Dto;

public class WineryDto
{
    public int Id { get; set; }

    [Required]
    [StringLength(250, ErrorMessage = "Name is too long (250 characters limit).")]
    public string Name { get; set; } = String.Empty;

    [StringLength(2000, ErrorMessage = "Description is too long (2000 characters limit).")]
    public string? Description { get; set; }
}
