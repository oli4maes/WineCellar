namespace WineCellar.Blazor.Features.Wine.Components;

public partial class AddBottleDialog : ComponentBase
{
    [CascadingParameter] private MudDialogInstance MudDialog { get; set; } = default!;

    internal BottlesToAdd Bottle { get; set; } = new();

    private void AddBottle()
    {
        MudDialog.Close(DialogResult.Ok(Bottle));
    }

    private void Cancel()
    {
        MudDialog.Cancel();
    }

    internal sealed class BottlesToAdd
    {
        public int? Vintage { get; set; }
        public int Amount { get; set; } = 1;
        public double PricePerBottle { get; set; }
        public BottleSize Size { get; set; } = BottleSize.Standard;
        public DateTime? AddedOn { get; set; } = DateTime.Today;
    }
}