namespace WineCellar.Blazor.Features.Wine.Components;

public partial class AddBottleToCellarDialog : ComponentBase
{
    [CascadingParameter] private MudDialogInstance _mudDialog { get; set; }

    public Bottle _bottle { get; set; } = new();

    private void AddBottle()
    {
        _mudDialog.Close(DialogResult.Ok(_bottle));
    }

    private void Cancel()
    {
        _mudDialog.Cancel();
    }

    public class Bottle
    {
        public int? Vintage { get; set; }
        public BottleSize Size { get; set; } = BottleSize.Standard;
    }
}