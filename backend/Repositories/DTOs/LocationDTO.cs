namespace Resenhapp.Repositories.DTOs;

public class LocationDTO: NamedBaseDTO
{
    public PersonDTO? Owner {get;set;}
    public int MaxCapacity {get;set;}
}
