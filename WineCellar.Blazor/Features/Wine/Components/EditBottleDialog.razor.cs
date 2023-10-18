using WineCellar.Application.Features.Cellar.GetBottlesByWineId;

namespace WineCellar.Blazor.Features.Wine.Components;

public partial class EditBottleDialog : ComponentBase
{
    [CascadingParameter] private MudDialogInstance _mudDialog { get; set; }
    [Parameter] public GetBottlesByWineIdResponse.BottleDto Bottle { get; set; }

    private void EditBottle()
    {
        _mudDialog.Close(DialogResult.Ok(Bottle));
    }

    private void Cancel()
    {
        _mudDialog.Cancel();
    }
}