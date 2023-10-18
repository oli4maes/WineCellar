namespace WineCellar.Application.Features.Cellar.BulkAddBottleToCellar;

public sealed class BulkAddBottleToCellarResponse
{
    public int AmountSucceeded { get; set; }
    public int AmountFailed { get; set; }
}