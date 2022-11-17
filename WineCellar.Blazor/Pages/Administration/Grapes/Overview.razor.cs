using WineCellar.Application.Grapes.Queries.GetGrapes;
using WineCellar.Application.Grapes.Commands.DeleteGrape;
using WineCellar.Blazor.Components.Dialog;

namespace WineCellar.Blazor.Pages.Administration.Grapes;

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

    private IEnumerable<Grape> _grapes = Enumerable.Empty<Grape>();
    private string _searchString = String.Empty;

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<Grape, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    protected override async Task OnInitializedAsync()
    {
        _grapes = await _mediator.Send(new GetGrapesQuery());
    }

    private void OpenGrape(Grape grape)
    {
        _navManager.NavigateTo($"/Administration/Grapes/{grape.Id}");
    }

    private void AddGrape()
    {
        _navManager.NavigateTo($"/Administration/Grapes/0");
    }

    private async Task DeleteGrape(Grape grape)
    {
        DialogParameters parameters = new();
        parameters.Add("ContentText", $"Do your really want ot delete grape {grape.Name}?");

        DialogOptions options = new() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            bool deleteSucces = await _mediator.Send(new DeleteGrapeCommand(grape.Id));

            if (deleteSucces)
            {
                _snackbar.Add($"Grape {grape.Name} deleted.", Severity.Warning);

                _grapes = await _mediator.Send(new GetGrapesQuery());
            }
            else
            {
                _snackbar.Add($"Could not delete grape {grape.Name}", Severity.Error);
            }
        }
    }
}

