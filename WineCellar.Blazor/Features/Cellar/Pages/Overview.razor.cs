using System.Security.Claims;
using Microsoft.AspNetCore.Components.Forms;
using WineCellar.Application.Features.Cellar.GetCellarOverview;

namespace WineCellar.Blazor.Features.Cellar.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }

    private IEnumerable<GetCellarOverviewResponse.CellarOverviewDto>? _userWines { get; set; }
    private string _userId { get; set; } = string.Empty;
    private string _userName { get; set; } = string.Empty;
    private bool _loading { get; set; } = true;
    private List<IBrowserFile> _files = [];
    

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userId = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
        _userName = authState.User.Identity?.Name ?? string.Empty;

        await GetUserWines();
        _loading = false;
    }

    private async Task GetUserWines()
    {
        var response = await _mediator.Send(new GetCellarOverviewRequest(_userId));
        _userWines = response.Bottles;
    }

    private void OpenWine(GetCellarOverviewResponse.CellarOverviewDto userWine)
    {
        _navManager.NavigateTo($"/Wines/{userWine.WineId}");
    }
    
    private void UploadFiles(IBrowserFile file)
    {
        _files.Add(file);
        //TODO upload the files to the server
    }
}