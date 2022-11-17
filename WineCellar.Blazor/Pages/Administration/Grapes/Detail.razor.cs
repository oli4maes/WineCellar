using System.ComponentModel;
using WineCellar.Application.Grapes.Commands.CreateGrape;
using WineCellar.Application.Grapes.Commands.UpdateGrape;
using WineCellar.Application.Grapes.Queries.GetGrapeById;

namespace WineCellar.Blazor.Pages.Administration.Grapes;

public partial class Detail : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    [Inject]
    MediatR.IMediator _mediator { get; set; }

    [Inject]
    private NavigationManager _navManager { get; set; }

    [Inject]
    private ISnackbar _snackbar { get; set; }

    private Grape _grape { get; set;} = new();
    private bool _editMode { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            _grape = await _mediator.Send(new GetGrapeByIdQuery(Id));
        }
        else
        {
            _grape = new();
            _editMode = true;
        }
    }

    private void SetEditMode()
    {
        _editMode = true;
    }

    protected async void HandleValidSubmit()
    {
        if (Id == 0) // Insert
        {
            _grape = await _mediator.Send(new CreateGrapeCommand(_grape.Name, _grape.Description));

            if (_grape is not null)
            {
                _editMode = false;
                _snackbar.Add("Saved", Severity.Success);                
            }
            else
            {
                _snackbar.Add("Could not save the grape.", Severity.Error);
            }
        }
        else // Update
        {
            await _mediator.Send(new UpdateGrapeCommand(_grape));

            _editMode = false;
            _snackbar.Add("Saved", Severity.Success);            
        }
    }

    private void Back()
    {
        _navManager.NavigateTo("/Administration/Grapes");
    }
}