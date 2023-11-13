namespace Resenhapp.Repositories.DTOs;

public class AddressDTO: BaseDTO
{
    public LocationDTO? Location {get;set;}
    public string? Street { get; set; }
    public int Number { get; set; }
    public string? Neighborhood { get; set; }
}