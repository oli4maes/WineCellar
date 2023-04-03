namespace WineCellar.Blazor.Shared.Components.Inputs;

public partial class SearchInput : ComponentBase
{
    [Parameter] public EventCallback<string> OnSearch { get; set; }

    private string QueryString { get; set; } = String.Empty;

    private async void Search()
    {
        await OnSearch.InvokeAsync(QueryString);
    }
}