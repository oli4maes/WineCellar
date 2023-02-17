using System.Security.Claims;
using WineCellar.Application.Features.Cellar.AddWineToCellar;
using WineCellar.Application.Features.Cellar.GetUserWineByWineId;
using WineCellar.Application.Features.Wines.GetWineById;

namespace WineCellar.Blazor.Pages.Wine;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private WineDto _wine;
    private string _userName { get; set; } = string.Empty;
    private string _auth0Id { get; set; } = string.Empty;
    private bool _isWineInUserWines { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;
        _auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

        var getWineByIdResponse = await _mediator.Send(new GetWineByIdRequest(Id));
        _wine = getWineByIdResponse.Wine ?? new WineDto();
        
        GetUserWineByWineIdResponse response = await _mediator.Send(new GetUserWineByWineIdRequest(_auth0Id, _wine.Id));

        if (response?.UserWine is not null)
        {
            _isWineInUserWines = true;
        }
    }

    private async Task AddWineToCellar()
    {
        var response = await _mediator.Send(new AddWineToCellarRequest(_wine.Id, 1, _userName, _auth0Id));

        if (response.UserWine is not null)
        {
            _snackbar.Add($"Added {_wine.Name} to your cellar.", Severity.Success);
        }
    }
}