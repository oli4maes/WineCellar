﻿namespace WineCellar.Blazor.Features.Cellar.Components;

public partial class DashboardCard : ComponentBase
{
    [Parameter] public string Title { get; set; } = String.Empty;
    [Parameter] public string Statistic { get; set; } = String.Empty;
    [Parameter] public int? FavouriteWineryId { get; set; }
    [Parameter] public int? FavouriteWineId { get; set; }
    [Parameter] public EventCallback<int> OnNavigateToWineDetail { get; set; }
    [Parameter] public EventCallback<int> OnNavigateToWineryDetail { get; set; }

    private async void Navigate()
    {
        if (FavouriteWineId is not null)
        {
            await OnNavigateToWineDetail.InvokeAsync((int)FavouriteWineId);
        }

        if (FavouriteWineryId is not null)
        {
            await OnNavigateToWineryDetail.InvokeAsync((int)FavouriteWineryId);
        }
    }
}