using System.Security.Claims;
using WineCellar.Application.Features.Cellar.BulkAddBottleToCellar;
using WineCellar.Application.Features.Cellar.DeleteBottle;
using WineCellar.Application.Features.Cellar.EditBottle;
using WineCellar.Application.Features.Cellar.GetBottlesByWineId;
using WineCellar.Application.Features.Cellar.SetBottleStatus;
using WineCellar.Application.Features.Wines.GetWineById;
using WineCellar.Blazor.Features.Wine.Components;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Wine.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator Mediator { get; set; } = default!;
    [Inject] private AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;
    [Inject] private ISnackbar Snackbar { get; set; } = default!;
    [Inject] private NavigationManager NavigationManager { get; set; } = default!;
    [Inject] private IDialogService DialogService { get; set; } = default!;

    private WineDto? _wine;
    private List<GetBottlesByWineIdResponse.BottleDto> BottlesInCellar { get; set; } = [];
    private List<GetBottlesByWineIdResponse.BottleDto> BottlesConsumed { get; set; } = [];
    private string UserName { get; set; } = string.Empty;
    private string Auth0Id { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        UserName = authState.User.Identity?.Name ?? string.Empty;
        Auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
    }

    protected override async Task OnParametersSetAsync()
    {
        var getWineByIdResponse = await Mediator.Send(new GetWineByIdRequest(Id));
        _wine = getWineByIdResponse.Wine ?? new();

        await GetBottles();
    }

    private async Task GetBottles()
    {
        var responseInCellar =
            await Mediator.Send(new GetBottlesByWineIdRequest(Auth0Id, _wine!.Id, BottleStatus.InCellar));
        BottlesInCellar = responseInCellar.Bottles!.OrderByDescending(x => x.AddedOn).ToList();

        var responseConsumed =
            await Mediator.Send(new GetBottlesByWineIdRequest(Auth0Id, _wine.Id, BottleStatus.Consumed));
        BottlesConsumed = responseConsumed.Bottles!.OrderByDescending(x => x.ConsumedOn).ToList();
    }

    private async Task AddBottleToCellar()
    {
        var dialog = await DialogService.ShowAsync<AddBottleDialog>();
        var result = await dialog.Result;
        var bottles = (AddBottleDialog.BottlesToAdd)result.Data;

        if (!result.Canceled)
        {
            var response = await Mediator.Send(new BulkAddBottleToCellarRequest(
                _wine.Id, bottles.Size, bottles.Amount, bottles.AddedOn, UserName, Auth0Id, bottles.PricePerBottle,
                bottles.Vintage));

            if (response.AmountFailed is 0)
            {
                Snackbar.Add($"Added {response.AmountSucceeded} bottle(s) to your cellar.", Severity.Success);
            }
            else
            {
                Snackbar.Add($"Failed to add {response.AmountFailed} bottle(s) to your cellar.", Severity.Error);
            }

            await GetBottles();
        }
    }

    private async Task OnEditBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        var parameters = new DialogParameters<EditBottleDialog> { { x => x.Bottle, bottle } };

        var dialog = await DialogService.ShowAsync<EditBottleDialog>("Edit bottle", parameters);
        var result = await dialog.Result;

        int.TryParse(bottle.Vintage, out var vintage);

        if (!result.Canceled)
        {
            await Mediator.Send(new EditBottleRequest(
                bottle.Id,
                bottle.BottleSize,
                bottle.AddedOn ?? DateTime.Today,
                UserName,
                bottle.Price,
                vintage == 0 ? null : vintage));
        }
    }

    private async Task OnDeleteBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        var parameters = new DialogParameters()
            { { "ItemToDelete", $"{bottle.BottleSize.ToString().ToLower()} - {bottle.AddedOn?.ToShortDateString()}" } };
        var dialog = await DialogService.ShowAsync<DeleteDialog>("Delete", parameters);
        var result = await dialog.Result;

        if (!result.Canceled)
        {
            var response = await Mediator.Send(new DeleteBottleRequest(bottle.Id));

            if (response.SuccessfulDelete)
            {
                Snackbar.Add($"Bottle deleted.", Severity.Warning);

                await GetBottles();
            }
            else
            {
                Snackbar.Add($"Could not delete bottle.", Severity.Error);
            }
        }
    }

    private async Task OnConsumeBottle(GetBottlesByWineIdResponse.BottleDto bottle)
    {
        var parameters = new DialogParameters<ConsumeBottleDialog> { { x => x.Bottle, bottle } };

        var dialog = await DialogService.ShowAsync<ConsumeBottleDialog>("Consume bottle", parameters);
        var result = await dialog.Result;

        if (!result.Canceled)
        {
            await Mediator.Send(new SetBottleStatusRequest(
                bottle.Id,
                BottleStatus.Consumed,
                bottle.ConsumedOn,
                UserName));
        }

        await GetBottles();
    }

    private void NavigateToWinery()
    {
        NavigationManager.NavigateTo($"/Wineries/{_wine.Winery.Id}");
    }
}