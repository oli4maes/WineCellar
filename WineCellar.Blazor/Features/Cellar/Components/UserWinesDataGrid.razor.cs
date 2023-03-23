using WineCellar.Application.Features.Cellar.GetCellarOverview;

namespace WineCellar.Blazor.Features.Cellar.Components;

public partial class UserWinesDataGrid : ComponentBase
{
    [Parameter] public IEnumerable<GetCellarOverviewResponse.UserWineOverviewDto> UserWines { get; set; }
    [Parameter] public EventCallback<GetCellarOverviewResponse.UserWineOverviewDto> OnOpenWine { get; set; }
    [Parameter] public EventCallback<GetCellarOverviewResponse.UserWineOverviewDto> OnDeleteUserWine { get; set; }

    private string _searchString = String.Empty;

    private Func<GetCellarOverviewResponse.UserWineOverviewDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.WineName.Contains(_searchString, StringComparison.OrdinalIgnoreCase) ||
            x.WineryName.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void OpenWine(GetCellarOverviewResponse.UserWineOverviewDto userWine)
    {
        OnOpenWine.InvokeAsync(userWine);
    }

    private void DeleteUserWine(GetCellarOverviewResponse.UserWineOverviewDto userWine)
    {
        OnDeleteUserWine.InvokeAsync(userWine);
    }
}