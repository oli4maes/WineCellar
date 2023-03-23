namespace WineCellar.Blazor.Shared.Components.Dialogs;

public partial class DeleteDialog : ComponentBase
{
    [CascadingParameter] private MudDialogInstance MudDialog { get; set; } = default!;

    [Parameter] public string? ItemToDelete { get; set; }
    [Parameter] public string? Text { get; set; }

    private void Cancel()
    {
        MudDialog.Cancel();
    }

    private void Delete()
    {
        MudDialog.Close(DialogResult.Ok(true));
    }
}