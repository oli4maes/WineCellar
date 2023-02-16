using System.ComponentModel.DataAnnotations;
using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.UserWines.GetUserWinesOverview;

public class GetUserWinesOverviewResponse
{
    public IEnumerable<UserWineOverviewDto> UserWines { get; set; }
    
    public class UserWineOverviewDto
    {
        public int Id { get; set; }
        
        [Required]
        public int WineId { get; set; }

        public string WineName { get; set; } = String.Empty;
        
        public string WineryName { get; set; } = String.Empty;
        
        public WineType WineType { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid amount. The minimum amount required is 1.")]
        public int Amount { get; set; }
    }
}

