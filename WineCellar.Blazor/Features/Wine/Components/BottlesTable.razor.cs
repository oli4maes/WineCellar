using WineCellar.Application.Features.Cellar.GetBottlesByWineId;

namespace WineCellar.Blazor.Features.Wine.Components;

public partial class BottlesTable : ComponentBase
{
    [Parameter] public List<GetBottlesByWineIdResponse.BottleDto> Bottles { get; set; } = new();
    [Parameter] public EventCallback<GetBottlesByWineIdResponse.BottleDto> OnSetBottleStatus { get; set; }

    private string _searchString = String.Empty;

    private void SetBottleStatus(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        OnSetBottleStatus.InvokeAsync(bottle);
    }
}