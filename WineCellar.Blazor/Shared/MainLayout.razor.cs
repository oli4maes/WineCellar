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
                FontWeight = 500
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Poppins", "Helvetica", "Arial", "sans-serif" }
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Poppins", "Helvetica", "Arial", "sans-serif" }
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Poppins", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 200
            },
            H4 = new H4()
            {
                FontFamily = new[] { "Poppins", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 400
            },
            H5 = new H5()
            {
                FontFamily = new[] { "Poppins", "Helvetica", "Arial", "sans-serif" },
                FontWeight = 300
            }
        },
        Palette = new Palette()
        {
            DrawerBackground = Colors.Grey.Lighten5,
            AppbarBackground = "#42707f",
            AppbarText = "#fff6e5",
            Primary = "#42707f",
            PrimaryContrastText = "#fff6e5",
            Secondary = "#B87D4B",
            SecondaryContrastText = "#19282C",
            Tertiary = "#19282C",
            TertiaryContrastText = "#B87D4B"
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
}