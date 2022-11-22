using WineCellar.Application.Wineries.Commands.DeleteWinery;
using WineCellar.Application.Wineries.Queries.GetWineries;
using WineCellar.Blazor.Components.Dialog;

namespace WineCellar.Blazor.Pages.Administration.Wineries;

public partial class Overview : ComponentBase
{
    [Inject]
    private MediatR.IMediator _mediator { get; set; }

    [Inject]
    private ISnackbar _snackbar { get; set; }

    [Inject]
    private NavigationManager _navManager { get; set; }

    [Inject]
    private IDialogService _dialogService { get; set; }

    private IEnumerable<WineryDto> _wineries = Enumerable.Empty<WineryDto>();
    private string _searchString = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await GetWineries();
    }

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<WineryDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void OpenWinery(WineryDto winery)
    {
        _navManager.NavigateTo($"/Administration/Wineries/{winery.Id}");
    }

    private void AddWinery()
    {
        _navManager.NavigateTo($"/Administration/Wineries/0");
    }

    private async Task DeleteWinery(WineryDto winery)
    {
        DialogParameters parameters = new();
        parameters.Add("ContentText", $"Do your really want ot delete winery {winery.Name}?");

        DialogOptions options = new() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            bool deleteSucces = await _mediator.Send(new DeleteWineryCommand(winery.Id));

            if (deleteSucces)
            {
                _snackbar.Add($"Grape {winery.Name} deleted.", Severity.Warning);

                await GetWineries();
            }
            else
            {
                _snackbar.Add($"Could not delete grape {winery.Name}", Severity.Error);
            }
        }
    }

    private async Task GetWineries()
    {
        _wineries = await _mediator.Send(new GetWineriesQuery());
    }
}