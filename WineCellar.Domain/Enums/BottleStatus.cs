namespace WineCellar.Domain.Enums;

public enum BottleStatus
{
    InCellar,
    Consumed
}

public static class BottleStatusExtensions
{
    public static string GetString(BottleStatus status)
    {
        switch (status)
        {
            case BottleStatus.InCellar:
                return "In cellar";
            case BottleStatus.Consumed:
                return BottleStatus.Consumed.ToString();
            default:
                throw new Exception("Unsupported bottle status");
        }
    }
}