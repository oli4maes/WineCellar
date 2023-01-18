namespace WineCellar.Blazor.Components.Dialog;

public partial class DeleteDialog : ComponentBase
{
    [CascadingParameter] 
    private MudDialogInstance MudDialog { get; set; } = default!;

    [Parameter] 
    public string? ContentText { get; set; }

    private void Cancel()
    {
        MudDialog.Close();
    }

    private void Delete()
    {
        MudDialog.Close(DialogResult.Ok(true));
    }
}