using WineCellar.Application.Features.Cellar.GetBottlesByWineId;

namespace WineCellar.Blazor.Features.Wine.Components;

public partial class BottlesTable : ComponentBase
{
    [Parameter] public List<GetBottlesByWineIdResponse.BottleDto> Bottles { get; set; } = [];
    [Parameter] public BottleStatus Status { get; set; }
    [Parameter] public EventCallback<GetBottlesByWineIdResponse.BottleDto> OnEditBottle { get; set; }
    [Parameter] public EventCallback<GetBottlesByWineIdResponse.BottleDto> OnDeleteBottle { get; set; }
    [Parameter] public EventCallback<GetBottlesByWineIdResponse.BottleDto> OnConsumeBottle { get; set; }

    private string _searchString = string.Empty;

    private void EditBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        OnEditBottle.InvokeAsync(bottle);
    }
    
    private void DeleteBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        OnDeleteBottle.InvokeAsync(bottle);
    }
    
    private void ConsumeBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        OnConsumeBottle.InvokeAsync(bottle);
    }
}