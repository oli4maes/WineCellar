using WineCellar.Blazor.Helpers;

namespace WineCellar.Blazor.Shared;

public partial class MainLayout
{
    [Inject] public IMudBlazorThemeHelper ThemeHelper { get; set; }

    private bool _drawerOpen = true;
    private bool _isDarkMode;
    private readonly DrawerClipMode _clipMode = DrawerClipMode.Always;
    private MudThemeProvider? _mudThemeProvider = new MudThemeProvider();
    private MudTheme _theme;

    protected override async Task OnInitializedAsync()
    {
        _theme = ThemeHelper.GetTheme();
    }

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    // protected override async Task OnAfterRenderAsync(bool firstRender)
    // {
    //     if (firstRender)
    //     {
    //         _isDarkMode = await _mudThemeProvider.GetSystemPreference();
    //         StateHasChanged();
    //     }
    // }
}