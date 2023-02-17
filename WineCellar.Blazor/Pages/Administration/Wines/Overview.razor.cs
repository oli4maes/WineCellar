using WineCellar.Application.Features.Wines.DeleteWine;
using WineCellar.Application.Features.Wines.GetWines;
using WineCellar.Blazor.Components.Dialog;

namespace WineCellar.Blazor.Pages.Administration.Wines;

public partial class Overview : ComponentBase
{
    [Inject]
    private IMediator _mediator { get; set; }

    [Inject]
    private ISnackbar _snackbar { get; set; }

    [Inject]
    private NavigationManager _navManager { get; set; }

    [Inject]
    private IDialogService _dialogService { get; set; }

    private IEnumerable<WineDto> _wines = Enumerable.Empty<WineDto>();
    private string _searchString = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await GetWines();
    }

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<WineDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void OpenWine(WineDto wine)
    {
        _navManager.NavigateTo($"/Administration/Wines/{wine.Id}");
    }

    private void AddWine()
    {
        _navManager.NavigateTo($"/Administration/Wines/0");
    }

    private async Task DeleteWine(WineDto wine)
    {
        DialogParameters parameters = new();
        parameters.Add("ContentText", $"Do your really want ot delete wine {wine.Name}?");

        DialogOptions options = new() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Canceled)
        {
            bool deleteSucces = await _mediator.Send(new DeleteWineCommand(wine.Id));

            if (deleteSucces)
            {
                _snackbar.Add($"Wine {wine.Name} deleted.", Severity.Warning);

                await GetWines();
            }
            else
            {
                _snackbar.Add($"Could not delete wine {wine.Name}", Severity.Error);
            }
        }
    }

    private async Task GetWines()
    {
        _wines = await _mediator.Send(new GetWinesQuery());
    }
}