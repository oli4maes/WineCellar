namespace WineCellar.Blazor.Shared;

public partial class MainLayout
{
    bool _drawerOpen = false;
    bool _isAdmin = false;
    bool _isDarkMode;
    MudThemeProvider _mudThemeProvider;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _isDarkMode = await _mudThemeProvider.GetSystemPreference();
            StateHasChanged();
        }
    }

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
}
