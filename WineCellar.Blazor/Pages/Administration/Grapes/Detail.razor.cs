using WineCellar.Application.Grapes.Queries.GetGrapeById;

namespace WineCellar.Blazor.Pages.Administration.Grapes;

public partial class Detail : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    [Inject]
    MediatR.IMediator _mediator { get; set; }

    private Grape _grape = new();

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            _grape = await _mediator.Send(new GetGrapeByIdQuery(Id));
        }        
    }
}