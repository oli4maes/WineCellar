namespace WineCellar.Blazor.Shared.Components.AppBar;

public partial class AppBar : ComponentBase
{
    [Parameter] public EventCallback DrawerToggle { get; set; }

    private void OnDrawerToggle()
    {
        DrawerToggle.InvokeAsync();
    }
}