using WineCellar.Application.Features.Grapes.DeleteGrape;
using WineCellar.Application.Features.Grapes.GetGrapes;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Administration.Grapes.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }

    [Inject] private ISnackbar _snackbar { get; set; }

    [Inject] private NavigationManager _navManager { get; set; }

    [Inject] private IDialogService _dialogService { get; set; }

    private IEnumerable<GrapeDto> _grapes = Enumerable.Empty<GrapeDto>();
    private string _searchString = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await GetGrapes();
    }

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<GrapeDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void OpenGrape(GrapeDto grape)
    {
        _navManager.NavigateTo($"/Administration/Grapes/{grape.Id}");
    }

    private void AddGrape()
    {
        _navManager.NavigateTo($"/Administration/Grapes/0");
    }

    private async Task DeleteGrape(GrapeDto grape)
    {
        DialogParameters parameters = new() { { "ItemToDelete", grape.Name.ToLower() } };
        var dialog = await _dialogService.ShowAsync<DeleteDialog>("Delete", parameters);
        var result = await dialog.Result;

        if (!result.Canceled)
        {
            var response = await _mediator.Send(new DeleteGrapeRequest(grape.Id));

            if (response.SuccessfulDelete)
            {
                _snackbar.Add($"Grape {grape.Name} deleted.", Severity.Warning);

                await GetGrapes();
            }
            else
            {
                _snackbar.Add($"Could not delete grape {grape.Name}", Severity.Error);
            }
        }
    }

    private async Task GetGrapes()
    {
        var getGrapesResponse = await _mediator.Send(new GetGrapesRequest());
        _grapes = getGrapesResponse.Grapes;
    }
}