using WineCellar.Application.Features.Cellar.GetBottlesByWineId;

namespace WineCellar.Blazor.Features.Wine.Components;

public partial class ConsumeBottleDialog : ComponentBase
{
    [CascadingParameter] private MudDialogInstance _mudDialog { get; set; }
    [Parameter] public GetBottlesByWineIdResponse.BottleDto Bottle { get; set; }

    private void Cancel()
    {
        _mudDialog.Cancel();
    }

    private void ConsumeBottle()
    {
        _mudDialog.Close(DialogResult.Ok(Bottle));
    }
}