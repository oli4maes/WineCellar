namespace WineCellar.Blazor.Features.Wine.Components;

public partial class WineInCellar : ComponentBase
{
    [Parameter] public int Amount { get; set; }
    [Parameter] public EventCallback OnRemoveBottle { get; set; }
    [Parameter] public EventCallback OnAddBottle { get; set; }

    private void RemoveBottle()
    {
        OnRemoveBottle.InvokeAsync();
    }

    private void AddBottle()
    {
        OnAddBottle.InvokeAsync();
    }
}