using System.Security.Claims;
using Microsoft.AspNetCore.Components.Forms;
using WineCellar.Application.Features.Cellar.GetCellarOverview;

namespace WineCellar.Blazor.Features.Cellar.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; } = default!;
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; } = default!;
    [Inject] private NavigationManager _navManager { get; set; } = default!;
    [Inject] private ISnackbar _snackbar { get; set; } = default!;

    private IEnumerable<GetCellarOverviewResponse.CellarOverviewDto> _userWines { get; set; }
    private string _userId { get; set; } = string.Empty;
    private string _userName { get; set; } = string.Empty;
    private bool _loading { get; set; } = true;
    const int MAX_FILESIZE = 1024 * 15;
    private string _errorMessage { get; set; } = string.Empty;


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

    private async Task UploadFile(IBrowserFile file)
    {
        try
        {
            var fileStream = file.OpenReadStream(MAX_FILESIZE);

            var tempFileName = Path.GetTempFileName();
            var extension = Path.GetExtension(file.Name);
            var targetFilePath = Path.ChangeExtension(tempFileName, extension);

            var targetStream = new FileStream(targetFilePath, FileMode.Create);
            await fileStream.CopyToAsync(targetStream);
            targetStream.Close();

            _snackbar.Add($"File {file.Name} was uploaded.", Severity.Success);
        }
        catch (Exception ex)
        {
            _snackbar.Add($"{ex.Message}", Severity.Error);
        }
    }
}