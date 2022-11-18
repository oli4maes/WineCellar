namespace WineCellar.Blazor;

public partial class MainLayout
{
    [Inject]
    private AuthenticationStateProvider _authStateProvider { get; set; }

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

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {            
            var claims = user.Identities.First().Claims;

            if (claims.Any(x => x.Value == "admin"))
            {
                _isAdmin= true;
            }
        }
    }

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
}
