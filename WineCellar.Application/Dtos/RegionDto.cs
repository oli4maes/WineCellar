namespace WineCellar.Application.Dtos;

public class RegionDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string CountryName { get; set; } =String.Empty;

    public override bool Equals(object o)
    {
        var other = o as RegionDto;
        return other?.Name == Name;
    }

    public override int GetHashCode() => Name.GetHashCode();

    public override string ToString() => Name;
}