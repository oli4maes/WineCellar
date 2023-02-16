using System.Security.Claims;
using MediatR;
using WineCellar.Application.Features.UserWines.CreateUserWine;
using WineCellar.Application.Features.UserWines.GetUserWineByWineId;
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

        _wine = await _mediator.Send(new GetWineByIdQuery(Id));
        UserWineDto? result = await _mediator.Send(new GetUserWineByWineIdQuery(_auth0Id, _wine.Id));

        if (result is not null)
        {
            _isWineInUserWines = true;
        }
    }

    private async Task AddWineToCellar()
    {
        UserWineDto result = await _mediator.Send(new CreateUserWineCommand(_wine.Id, 1, _userName, _auth0Id));

        if (result is not null)
        {
            _snackbar.Add($"Added {_wine.Name} to your cellar.", Severity.Success);
        }
    }
}