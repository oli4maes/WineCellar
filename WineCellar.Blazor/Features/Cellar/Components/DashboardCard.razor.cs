namespace WineCellar.Blazor.Features.Cellar.Components;

public partial class DashboardCard : ComponentBase
{
    [Parameter] public string Title { get; set; } = String.Empty;
    [Parameter] public string Statistic { get; set; } = String.Empty;
}