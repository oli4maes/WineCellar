﻿using MediatR;
using WineCellar.Application.Features.Wines.GetWines;

namespace WineCellar.Blazor.Components.Common;

public partial class WineSearchInput : ComponentBase
{
    [Parameter] public bool Dense { get; set; }
    [Parameter] public Margin Margin { get; set; }
    
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }

    private IEnumerable<WineDto> _wines;

    protected override async Task OnInitializedAsync()
    {
        _wines = await _mediator.Send(new GetWinesQuery());
    }
    
    private async Task<IEnumerable<WineDto>> SearchWine(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new List<WineDto>();

        return _wines.Where(x =>
            x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase) ||
            x.Winery.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    private void SelectedWineChanged(WineDto wine)
    {
     _navManager.NavigateTo($"/Wines/{wine.Id}");   
    }
}