using WineCellar.Application.Grapes.Queries.GetGrapes;

namespace WineCellar.Blazor.Pages.Administration.Grapes;

public partial class Overview : ComponentBase
{
    [Inject]
    private MediatR.IMediator _mediator { get; set; }

    [Inject]
    private NavigationManager _navManager { get; set; }

    [Inject]
    private IDialogService _dialogService { get; set; }

    private List<Grape> _grapes = new List<Grape>();
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

    private void DeleteGrape(Grape grape)
    {

    }
}

