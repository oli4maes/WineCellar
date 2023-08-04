namespace WineCellar.Blazor.Shared;

public partial class MainLayout
{
    private bool _drawerOpen = true;
    private bool _isDarkMode;
    private readonly DrawerClipMode _clipMode = DrawerClipMode.Always;
    private MudThemeProvider? _mudThemeProvider;

    private readonly MudTheme _theme = new()
    {
        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Open Sans", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 500
            },
            H1 = new H1() // ONLY USED FOR LOGIN SCREEN
            {
                FontFamily = new[] { "Lato", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 900
            },
            H2 = new H2() // ONLY USED FOR APPBAR LOGO
            {
                FontFamily = new[] { "Lato", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 900,
                FontSize = "2.125rem"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Lato", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 200
            },
            H4 = new H4() // USED FOR PAGE HEADERS
            {
                FontFamily = new[] { "Lato", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 300
            },
            H5 = new H5() // USED FOR CARD HEADERS
            {
                FontFamily = new[] { "Lato", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 400
            },
            H6 = new H6()
            {
                FontFamily = new[] { "Lato", "Helvetica", "Arial", "sans-serif" },
            }
        },
        Palette = new PaletteLight
        {
            DrawerBackground = "#fbfbfc",
            TextPrimary = "#5f4d46",
            Background = "#fbfbfc",
            AppbarBackground = "#fbfbfc",
            Primary = "#f1511b"
        }
    };

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