namespace WineCellar.Application.Dtos;

public class CountryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public override bool Equals(object o)
    {
        var other = o as CountryDto;
        return other?.Name == Name;
    }

    public override int GetHashCode() => Name.GetHashCode();

    public override string ToString() => Name;
}