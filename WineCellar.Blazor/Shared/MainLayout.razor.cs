namespace WineCellar.Blazor.Shared;

public partial class MainLayout
{
    private bool _drawerOpen = true;
    private bool _isDarkMode;
    private DrawerClipMode _clipMode = DrawerClipMode.Always;
    
    private MudThemeProvider _mudThemeProvider;

    // protected override async Task OnAfterRenderAsync(bool firstRender)
    // {
    //     if (firstRender)
    //     {
    //         _isDarkMode = await _mudThemeProvider.GetSystemPreference();
    //         StateHasChanged();
    //     }
    // }

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
}