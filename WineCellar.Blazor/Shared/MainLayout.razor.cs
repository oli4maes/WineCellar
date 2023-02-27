namespace WineCellar.Blazor.Shared;

public partial class MainLayout
{
    private bool _drawerOpen = true;
    private bool _isDarkMode;
    private readonly DrawerClipMode _clipMode = DrawerClipMode.Always;
    private MudThemeProvider _mudThemeProvider;

    private readonly MudTheme _theme = new()
    {
        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Open Sans", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 400
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Fira Sans", "Helvetica", "Arial", "sans-serif" }
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Fira Sans", "Helvetica", "Arial", "sans-serif" }
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Fira Sans", "Helvetica", "Arial", "sans-serif" }
            },
            H4 = new H4()
            {
                FontFamily = new[] { "Fira Sans", "Helvetica", "Arial", "sans-serif" }
            },
            H5 = new H5()
            {
                FontFamily = new[] { "Fira Sans", "Helvetica", "Arial", "sans-serif" }
            },
            H6 = new H6()
            {
                FontFamily = new[] { "Fira Sans", "Helvetica", "Arial", "sans-serif" }
            },
        }
    };

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