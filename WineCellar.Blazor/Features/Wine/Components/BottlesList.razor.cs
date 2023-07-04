using WineCellar.Application.Features.Cellar.GetBottlesByWineId;

namespace WineCellar.Blazor.Features.Wine.Components;

public partial class BottlesList : ComponentBase
{
    [Parameter] public List<GetBottlesByWineIdResponse.BottleDto> Bottles { get; set; } = new();
}