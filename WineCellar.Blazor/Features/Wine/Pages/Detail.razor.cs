using System.Security.Claims;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Application.Features.Cellar.DeleteBottle;
using WineCellar.Application.Features.Cellar.EditBottle;
using WineCellar.Application.Features.Cellar.GetBottlesByWineId;
using WineCellar.Application.Features.Grapes.DeleteGrape;
using WineCellar.Application.Features.Wines.GetWineById;
using WineCellar.Blazor.Features.Wine.Components;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Wine.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }

    private WineDto _wine;
    private List<GetBottlesByWineIdResponse.BottleDto> _bottles { get; set; } = new();
    private string _userName { get; set; } = string.Empty;
    private string _auth0Id { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;
        _auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
    }

    protected override async Task OnParametersSetAsync()
    {
        var getWineByIdResponse = await _mediator.Send(new GetWineByIdRequest(Id));
        _wine = getWineByIdResponse.Wine ?? new();

        await GetBottles();
    }

    private async Task GetBottles()
    {
        GetBottlesByWineIdResponse response = await _mediator.Send(new GetBottlesByWineIdRequest(_auth0Id, _wine.Id));
        _bottles = response.Bottles;
    }

    private async Task AddBottleToCellar()
    {
        var dialog = await _dialogService.ShowAsync<AddBottleDialog>();
        var result = await dialog.Result;
        AddBottleDialog.Bottle bottle = (AddBottleDialog.Bottle)result.Data;

        if (!result.Canceled)
        {
            var response = await _mediator.Send(
                new AddBottleToCellarRequest(_wine.Id, bottle.Size, _userName, _auth0Id, bottle.Vintage));

            if (response.Bottle is not null)
            {
                await GetBottles();
                _snackbar.Add($"Added bottle to your cellar.", Severity.Success);
            }
        }
    }

    private async Task OnEditBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        var parameters = new DialogParameters<EditBottleDialog>();
        parameters.Add(x => x.Bottle, bottle);

        var dialog = await _dialogService.ShowAsync<EditBottleDialog>("Edit bottle", parameters);
        var result = await dialog.Result;

        int vintage;
        int.TryParse(bottle.Vintage, out vintage);

        if (!result.Canceled)
        {
            await _mediator.Send(new EditBottleRequest(bottle.Id, bottle.BottleSize, _userName, vintage == 0 ? null : vintage));
        }
    }

    private async Task OnDeleteBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        DialogParameters parameters = new() { { "ItemToDelete", $"{bottle.BottleSize.ToString()} - {bottle.AddedOn.ToShortDateString()}" } };
        var dialog = await _dialogService.ShowAsync<DeleteDialog>("Delete", parameters);
        var result = await dialog.Result;

        if (!result.Canceled)
        {
            var response = await _mediator.Send(new DeleteBottleRequest(bottle.Id));

            if (response.SuccessfulDelete)
            {
                _snackbar.Add($"Bottle deleted.", Severity.Warning);

                await GetBottles();
            }
            else
            {
                _snackbar.Add($"Could not delete bottle.", Severity.Error);
            }
        }
    }

    private void NavigateToWinery()
    {
        _navigationManager.NavigateTo($"/Wineries/{_wine.Winery.Id}");
    }
}