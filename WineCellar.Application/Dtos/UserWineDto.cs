using System.ComponentModel.DataAnnotations;

namespace WineCellar.Application.Dtos;

public class UserWineDto
{
    public int Id { get; set; }

    [Required]
    public int WineId { get; set; }

    public WineDto? Wine { get; set; } = new();

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid amount. The minimum amount required is 1.")]
    public int Amount { get; set; }
}
