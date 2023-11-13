namespace Resenhapp.Repositories.Models;

public class Address: Base
{
    public Location? Location {get;set;}
    public string? Street { get; set; }
    public int Number { get; set; }
    public string? Neighborhood { get; set; }
}
