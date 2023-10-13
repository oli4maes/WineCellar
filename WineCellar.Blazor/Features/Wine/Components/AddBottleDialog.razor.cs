namespace WineCellar.Blazor.Features.Wine.Components;

public partial class AddBottleDialog : ComponentBase
{
    [CascadingParameter] private MudDialogInstance _mudDialog { get; set; }

    internal BottlesToAdd _bottle { get; set; } = new();

    private void AddBottle()
    {
        _mudDialog.Close(DialogResult.Ok(_bottle));
    }

    private void Cancel()
    {
        _mudDialog.Cancel();
    }

    internal sealed class BottlesToAdd
    {
        public int? Vintage { get; set; }
        public int Amount { get; set; } = 1;
        public BottleSize Size { get; set; } = BottleSize.Standard;
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;
    }
}